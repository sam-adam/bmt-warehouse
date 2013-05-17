namespace Warehouse.Presentation
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Warehouse.Data.Model;
    using Warehouse.Business;
    using Warehouse.Presentation.View;

    public partial class RentalAgreementFrm : Form
    {
        private readonly RentalAgreementBl _rentalAgreementBl;
        private readonly CustomerView _customerView;

        private Customer _customer;
        private ProductCategory _productCategory;
        private ProductSubcategory _productSubcategory;

        public RentalAgreementFrm(RentalAgreementBl rentalAgreementBl, CustomerView customerView)
        {   
            InitializeComponent();

            _rentalAgreementBl = rentalAgreementBl;
            _customerView = customerView;
        }

        private void txtCustomerId_TextChanged(object sender, System.EventArgs e)
        {
            if (txtCustomerId.Text.Length != 6)
            {
                ClearCustomerData();

                dgvProductCategoryPrice.Rows.Clear();

                return;
            }

            _customer = _rentalAgreementBl.GetCustomer(cust => cust.Id == txtCustomerId.Text);

            if (_customer != null)
            {
                if (_customer.HasRentalAgreement())
                {
                    if (MessageBox.Show(string.Format("Customer \'{0}\' has an active agreement. Do you want to duplicate current active agreement?", _customer.Name), @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SetCustomerData(_customer);
                    }
                    else
                    {
                        txtCustomerId.Text = string.Empty;

                        ClearCustomerData();
                    }
                }
                else
                {
                    SetCustomerData(_customer);
                }
            }
            else
            {
                ClearCustomerData();
            }
        }

        private void SetCustomerData(Customer customer)
        {
            var customerRentalAgreement = customer.GetActiveRental();

            dgvProductCategoryPrice.Rows.Clear();

            txtCustomerId.Text = customer.Id;
            txtCustomerTitle.Text = customer.Title ?? "";
            txtCustomerName.Text = customer.Name;
            txtCustomerPhone.Text = customer.Phone ?? "";
            txtCustomerAddress.Text = customer.Address1 + Environment.NewLine +
                                      customer.Address2 + Environment.NewLine +
                                      customer.Address3;
            txtCustomerEmail.Text = customer.Email ?? "";

            if (customerRentalAgreement != null)
            {
                var idx = dgvProductCategoryPrice.Rows.Add();
                
                foreach (RentalAgreementDetail rentalAgreementDetail in customerRentalAgreement.Details)
                {
                    var dgvRow = dgvProductCategoryPrice.Rows[idx];

                    var categoryId = rentalAgreementDetail.Category.Id;
                    var categoryName = rentalAgreementDetail.Category.Category;
                    var subcategoryId = rentalAgreementDetail.Subcategory.Id;
                    var subcategoryName = rentalAgreementDetail.Subcategory.Subcategory;
                    var price = rentalAgreementDetail.Price.ToString(CultureInfo.InvariantCulture);

                    dgvRow.Cells["ProductCategoryId"].Value = categoryId;
                    dgvRow.Cells["ProductCategory"].Value = categoryName;
                    dgvRow.Cells["ProductSubcategoryId"].Value = subcategoryId;
                    dgvRow.Cells["ProductSubcategory"].Value = subcategoryName;
                    dgvRow.Cells["Price"].Value = price;

                    idx++;
                }
            }
            else
            {
                dgvProductCategoryPrice.Rows.Add();   
            }
        }

        private void ClearCustomerData()
        {
            txtCustomerTitle.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtCustomerAddress.Text = string.Empty;
            txtCustomerEmail.Text = string.Empty;

            dgvProductCategoryPrice.Rows.Clear();
        }

        private void dgvProductCategoryPrice_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var dgvProductCategoryColumn = dgvProductCategoryPrice.Columns["ProductCategoryId"];
            var dgvProductSubcategoryColumn = dgvProductCategoryPrice.Columns["ProductSubcategoryId"];

            if (dgvProductCategoryColumn != null && dgvProductSubcategoryColumn != null && e.RowIndex > -1)
            {
                var dgvProductCategory = dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductCategoryId"].Value.ToString();

                if (e.ColumnIndex == dgvProductCategoryColumn.Index)
                {
                    _productCategory = _rentalAgreementBl.GetProductCategory(cat => cat.Id == dgvProductCategory.ToUpper());

                    if (_productCategory != null)
                    {
                        dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductCategory"].Value = _productCategory.Category;
                    }
                    else
                    {
                        foreach (DataGridViewCell dgc in dgvProductCategoryPrice.Rows[e.RowIndex].Cells)
                        {
                            dgc.Value = string.Empty;
                        }
                    }
                }
                else if (e.ColumnIndex == dgvProductSubcategoryColumn.Index)
                {
                    var dgvProductSubcategory = dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductSubcategoryId"].Value.ToString();

                    try
                    {
                        _productSubcategory = _rentalAgreementBl.GetProductSubcategory(dgvProductSubcategory.ToUpper(), _productCategory);

                        if (_productSubcategory != null)
                        {
                            dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductSubcategory"].Value = _productSubcategory.Subcategory;

                            if (e.RowIndex == dgvProductCategoryPrice.Rows.Count - 1 && dgvProductCategoryPrice.Rows[e.RowIndex].ReadOnly == false)
                            {
                                dgvProductCategoryPrice.Rows.Add();   
                            }
                        }
                        else
                        {
                            dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductSubcategoryId"].Value = string.Empty;
                            dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductSubcategory"].Value = string.Empty;
                        }
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message);

                        dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductSubcategoryId"].Value = string.Empty;
                        dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductSubcategory"].Value = string.Empty;
                    }
                }

                dgvProductCategoryPrice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvProductCategoryPrice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
            }
        }

        private void dgvProductCategoryPrice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvProductCategoryPrice.Columns["ProductCategoryId"] != null)
            {
                if (e.ColumnIndex != dgvProductCategoryPrice.Columns["ProductCategoryId"].Index && dgvProductCategoryPrice.Rows[e.RowIndex].Cells["ProductCategoryId"].Value == null)
                {
                    MessageBox.Show(@"Please fill product category first");

                    e.Cancel = true;
                }   
            }
        }

        private void dgvProductCategoryPrice_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvProductCategoryPrice.Rows.Count == 1)
            {
                MessageBox.Show(@"Minimum of one price detail");

                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateRentalAgreement())
            {
                try
                {
                    for (var i = 0; i < dgvProductCategoryPrice.Rows.Count - 1; i++)
                    {
                        _rentalAgreementBl.AddNewRentalAgreementDetail(
                            dgvProductCategoryPrice.Rows[i].Cells["ProductCategoryId"].Value.ToString(),
                            dgvProductCategoryPrice.Rows[i].Cells["ProductSubcategoryId"].Value.ToString(),
                            Double.Parse(dgvProductCategoryPrice.Rows[i].Cells["Price"].Value.ToString()));
                    }

                    _rentalAgreementBl.AddNewRentalAgreement(dtpAgreementDate.Value, int.Parse(numCutOffDate.Value.ToString(CultureInfo.InvariantCulture)), txtReference.Text);

                    var message = _rentalAgreementBl.SaveNewRentalAgreement();

                    MessageBox.Show(message);

                    foreach (Control control in this.Controls)
                    {
                        if (control.GetType() == typeof(TextBox))
                        {
                            control.Text = string.Empty;
                        }
                    }

                    dgvProductCategoryPrice.Rows.Clear();
                    dgvProductCategoryPrice.Rows.Add();

                    txtCustomerId.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Failed to insert new data. Contact system admin for more information.");
                }   
            }
        }

        private bool ValidateRentalAgreement()
        {
            if (txtCustomerName.Text == string.Empty)
            {
                MessageBox.Show(@"Customer cannot be empty");

                txtCustomerId.Focus();

                return false;
            }
            else if (txtSender.Text == string.Empty)
            {
                MessageBox.Show(@"Sender cannot be empty");

                txtSender.Focus();

                return false;
            }
            else if (txtReference.Text == string.Empty)
            {
                MessageBox.Show(@"External Reference cannot be empty");

                txtReference.Focus();

                return false;
            }
            else
            {
                if (dgvProductCategoryPrice.Rows.Count < 2)
                {
                    MessageBox.Show(@"Rental agreement need minimum of one detail");

                    dgvProductCategoryPrice.Focus();

                    return false;
                }

                for (int index = 0; index < dgvProductCategoryPrice.Rows.Count - 1; index++)
                {
                    DataGridViewRow row = dgvProductCategoryPrice.Rows[index];

                    if (row.Cells["ProductCategory"].Value == null
                        || row.Cells["ProductSubcategory"].Value == null
                        || row.Cells["Price"].Value == null)
                    {
                        MessageBox.Show(@"There is an invalid data in the detail");

                        dgvProductCategoryPrice.Focus();

                        return false;
                    }
                }
            }

            return true;
        }

        private void LoadCustomerView()
        {
            _customerView.ShowDialog();
            
            txtCustomerId.Text = _customerView.SelectedCustomer.Id;
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                LoadCustomerView();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}