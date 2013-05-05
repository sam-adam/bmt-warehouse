namespace Warehouse.Presentation
{
    using Autofac;
    using System;
    using System.Windows.Forms;
    using Warehouse.Data.Model;
    using Warehouse.Business;

    public partial class RentalAgreement : Form
    {
        private readonly IContainer _container;
        private readonly RentalAgreementBl _rentalAgreementBl;

        private Customer _customer;
        private ProductCategory _productCategory;
        private ProductSubcategory _productSubcategory;  

        public RentalAgreement(IContainer container)
        {   
            InitializeComponent();

            _container = container;
            _rentalAgreementBl = container.Resolve<RentalAgreementBl>();
        }


        private void RentalAgreement_Load(object sender, EventArgs e)
        {
            dgvProductCategoryPrice.Rows.Add();
        }

        private void txtCustomerId_TextChanged(object sender, System.EventArgs e)
        {
            _customer = _rentalAgreementBl.GetCustomer(cust => cust.Id == txtCustomerId.Text);
            
            if (_customer != null)
            {
                SetCustomerData(_customer);
            }
            else
            {
                ClearCustomerData();
            }
        }

        private void SetCustomerData(Customer customer)
        {
            txtCustomerId.Text = customer.Id;
            txtCustomerTitle.Text = customer.Title ?? "";
            txtCustomerName.Text = customer.Name;
            txtCustomerPhone.Text = customer.Phone ?? "";
            txtCustomerAddress.Text = customer.Address1 + Environment.NewLine +
                                      customer.Address2 + Environment.NewLine +
                                      customer.Address3;
            txtCustomerEmail.Text = customer.Email ?? "";
        }

        private void ClearCustomerData()
        {
            txtCustomerTitle.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtCustomerAddress.Text = string.Empty;
            txtCustomerEmail.Text = string.Empty;
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

                            if (e.RowIndex == dgvProductCategoryPrice.Rows.Count - 1)
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
                    _rentalAgreementBl.AddNewRentalAgreement(dtpAgreementDate.Value, txtReference.Text);

                    for (int i = 0; i < dgvProductCategoryPrice.Rows.Count - 1; i++)
                    {
                        _rentalAgreementBl.AddNewRentalAgreementDetail(
                            dgvProductCategoryPrice.Rows[i].Cells["ProductCategoryId"].Value.ToString(),
                            dgvProductCategoryPrice.Rows[i].Cells["ProductSubcategoryId"].Value.ToString(),
                            Double.Parse(dgvProductCategoryPrice.Rows[i].Cells["Price"].Value.ToString()));
                    }

                    var newRentalId = _rentalAgreementBl.SaveNewRentalAgreement();

                    MessageBox.Show(string.Format("Rental Agreement : {0} is created", newRentalId));

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
                    MessageBox.Show(@"Failed to insert new data. Contact system admin to investigate.");
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
    }
}