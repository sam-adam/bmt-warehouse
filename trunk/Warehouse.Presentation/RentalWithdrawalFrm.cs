namespace Warehouse.Presentation
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.View;

    public partial class RentalWithdrawalFrm : Form
    {
        private readonly CustomerView _customerView;
        private readonly IRentalWithdrawalBl _rentalWithdrawalBl;
        private readonly IRentalProductBl _rentalProductBl;

        public RentalWithdrawalFrm(IRentalWithdrawalBl rentalWithdrawalBl, CustomerView customerView, IRentalProductBl rentalProductBl)
        {
            _rentalWithdrawalBl = rentalWithdrawalBl;
            _customerView = customerView;
            _rentalProductBl = rentalProductBl;

            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                LoadCustomerView();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            ClearForm(txtCustomerId);
            dgvRentalWithdrawalDetail.Rows.Clear();

            if (txtCustomerId.Text.Length >= 6)
            {
                var customer = _rentalWithdrawalBl.GetCustomer(txtCustomerId.Text);

                if (customer != null)
                {
                    SetCustomer(customer);
                    SetRentalProducts(customer);

                    txtReference.Focus();
                }
                else
                {
                    txtCustomerId.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Create new rental withdrawal?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var withdrawal = new RentalWithdrawal();

                var customer = _rentalWithdrawalBl.GetCustomer(txtCustomerId.Text);

                withdrawal.Customer = customer;
                withdrawal.CreatedDate = dtpTransactionDate.Value;
                withdrawal.WithdrawalDate = dtpRentalDate.Value;
                withdrawal.Reference = txtReference.Text;

                foreach (DataGridViewRow row in dgvRentalWithdrawalDetail.Rows)
                {
                    if (int.Parse(row.Cells["Quantity"].Value.ToString()) > 0)
                    {
                        var product = _rentalProductBl.Get(row.Cells["ProductId"].Value.ToString()).First();

                        var withdrawalDetail = new RentalWithdrawalDetail
                            {
                                RentalWithdrawal = withdrawal,
                                RentalProduct = product,
                                Quantity = int.Parse(row.Cells["Quantity"].Value.ToString())
                            };

                        withdrawal.AddDetail(withdrawalDetail);
                    }
                }

                var message = _rentalWithdrawalBl.Save(withdrawal);

                MessageBox.Show(message);

                ClearForm(null);
            }
        }

        private void LoadCustomerView()
        {
            _customerView.ShowDialog();

            txtCustomerId.Text = _customerView.SelectedCustomer.Id;
        }

        private void ClearForm(object sender)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox) && !ReferenceEquals(control, sender))
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void SetCustomer(Customer customer)
        {
            txtCustomerTitle.Text = customer.Title;
            txtCustomerName.Text = customer.Name;
            txtCustomerPhone.Text = customer.Phone;
            txtCustomerAddress.Text = customer.Address1 + Environment.NewLine +
                                      customer.Address2 + Environment.NewLine +
                                      customer.Address3;
            txtCustomerEmail.Text = customer.Email;
        }
        
        private void SetRentalProducts(Customer customer)
        {
            var rentalProducts = _rentalWithdrawalBl.GetCustomerRentalProducts(customer);

            dgvRentalWithdrawalDetail.Rows.Clear();

            if (rentalProducts != null)
            {
                foreach (var rentalProduct in rentalProducts)
                {
                    dgvRentalWithdrawalDetail.Rows.Add(rentalProduct.Id,
                                                        rentalProduct.ProductCategory.Id,
                                                        rentalProduct.ProductCategory.Category,
                                                        rentalProduct.ProductSubcategory.Id,
                                                        rentalProduct.ProductSubcategory.Subcategory,
                                                        rentalProduct.Brand,
                                                        rentalProduct.Description,
                                                        rentalProduct.Stock,
                                                        "0", "");
                }
            }
            else
            {
                MessageBox.Show(string.Format("Customer \'{0}\' has no rental item", customer.Name));
            }
        }

        private void dgvRentalWithdrawalDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvRentalWithdrawalDetail.CurrentRow;

            if (currentRow != null)
            {
                var stockColumn = dgvRentalWithdrawalDetail.Columns["Stock"];
                var quantityColumn = dgvRentalWithdrawalDetail.Columns["Quantity"];

                if (quantityColumn != null && stockColumn != null && e.ColumnIndex == quantityColumn.Index)
                {
                    if (int.Parse(currentRow.Cells[quantityColumn.Index].Value.ToString()) > int.Parse(currentRow.Cells[stockColumn.Index].Value.ToString()))
                    {
                        MessageBox.Show(@"Quantity cannot be larger than stock");

                        currentRow.Cells[quantityColumn.Index].Value = 0;
                    }
                }
            }
            
        }
    }
}
