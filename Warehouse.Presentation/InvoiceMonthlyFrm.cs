﻿namespace Warehouse.Presentation
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.View;

    public partial class InvoiceMonthlyFrm : Form
    {
        private readonly CustomerView _customerView;
        private readonly IInvoiceMonthlyBl _invoiceMonthlyBl;

        private Customer _customer = null;

        public InvoiceMonthlyFrm(CustomerView customerView, IInvoiceMonthlyBl invoiceMonthlyBl)
        {
            _customerView = customerView;
            _invoiceMonthlyBl = invoiceMonthlyBl;

            InitializeComponent();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();   
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerId.Text.Length == 6)
            {
                try
                {
                    _customer = _invoiceMonthlyBl.GetCustomer(txtCustomerId.Text);

                    SetData(_customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    ClearForm(txtCustomerId);

                    txtCustomerId.Focus();
                }
            }
            else
            {
                ClearForm(txtCustomerId);
            }
        }

        private void LoadCustomerView()
        {
            _customerView.ShowDialog();

            _customer = _customerView.SelectedCustomer;

            if (_customer != null)
            {
                txtCustomerId.Text = _customer.Id;
            }
        }

        private void ClearForm(object sender = null)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox) && !ReferenceEquals(control, sender))
                {
                    control.Text = string.Empty;
                }
            }

            dgvInvoiceMonthlyDetail.Rows.Clear();
        }

        private void SetData(Customer customer)
        {
            var activeRental = customer.GetActiveRental();

            txtCustomerTitle.Text = customer.Title;
            txtCustomerName.Text = customer.Name;
            txtCustomerPhone.Text = customer.Phone;
            txtCustomerAddress.Text = customer.Address1 + Environment.NewLine +
                                        customer.Address2 + Environment.NewLine +
                                        customer.Address3;
            txtCustomerEmail.Text = customer.Email;
            txtAgreementId.Text = activeRental.Id;
            txtAgreementSales.Text = activeRental.CreatedBy.Id;
            txtAgreementSalesName.Text = activeRental.CreatedBy.Name;
            txtAgreementReference.Text = activeRental.Reference;
            txtAgreementCutOffDate.Text = activeRental.CutOffDate.ToString(CultureInfo.InvariantCulture);
            txtDiscount.Text = string.Empty;
            txtDiscountRemark.Text = string.Empty;
            dtpAgreementDate.Value = activeRental.AgreementDate;
            dtpAgreementCreatedDate.Value = activeRental.CreatedDate;

            dgvInvoiceMonthlyDetail.Rows.Clear();

            var products = _invoiceMonthlyBl.GetProducts(customer);

            if (products != null)
            {
                foreach (var product in products)
                {
                    var productPrice = _invoiceMonthlyBl.GetProductPrice(activeRental, product);
                    var subtotal = product.Stock * productPrice;

                    dgvInvoiceMonthlyDetail.Rows.Add(product.Id, product.ProductCategory.Id,
                                                     product.ProductCategory.Category, product.ProductSubcategory.Id,
                                                     product.ProductSubcategory.Subcategory, product.Brand,
                                                     product.Description, product.Stock, productPrice,
                                                     subtotal);
                }
            }

            var total = CountTotal();

            txtTotal.Text = total.ToString(CultureInfo.InvariantCulture);

            txtDiscount.Focus();
        }

        private Double CountTotal()
        {
            Double total = 0;
            Double discount = 0;

            foreach (DataGridViewRow row in dgvInvoiceMonthlyDetail.Rows)
            {
                total += Double.Parse(row.Cells["Subtotal"].Value.ToString());
            }

            if (Double.TryParse(txtDiscount.Text, out discount))
            {
                total -= discount;
            }

            return total;
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            var total = CountTotal();

            if (total < 0)
            {
                MessageBox.Show(@"Total price is lower than zero");

                txtDiscount.Text = @"0";

                return;
            }

            txtTotal.Text = total.ToString(CultureInfo.InvariantCulture);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToCharArray();

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != decimalSeparator[0])
            {
                e.Handled = true;
            }

            var textBox = sender as TextBox;

            if (textBox != null && (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                LoadCustomerView();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var invoiceMonthly = new InvoiceMonthly()
                    {
                        Id = _invoiceMonthlyBl.GenerateNewId(),
                        Discount = Double.Parse(txtDiscount.Text),
                        DiscountRemark = txtDiscountRemark.Text,
                        RentalAgreement = _customer.GetActiveRental(),
                        InvoiceDate = dtpInvoiceDate.Value
                    };
                foreach (DataGridViewRow row in dgvInvoiceMonthlyDetail.Rows)
                {
                    invoiceMonthly.AddDetail(new InvoiceMonthlyDetail()
                        {
                            InvoiceMonthly = invoiceMonthly,
                            RentalProduct = _invoiceMonthlyBl.GetRentalProduct(row.Cells["ProductId"].Value.ToString()),
                            Price = Double.Parse(row.Cells["Price"].Value.ToString()),
                            Quantity = int.Parse(row.Cells["Stock"].Value.ToString())
                        });   
                }

                var message = _invoiceMonthlyBl.Save(invoiceMonthly);

                ClearForm(null);

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}