namespace Warehouse.Presentation
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Print;
    using Warehouse.Presentation.View;

    public partial class RentalAgreementFrm : Form
    {
        private readonly ICustomerBl _customerBl;
        private readonly IRentalAgreementBl _rentalAgreementBl;
        private readonly RentalAgreementDetailFacade _detailFacade;
        private readonly CustomerView _customerView;
        private readonly ProductSubcategoryView _productSubcategoryView;
        private readonly PrintFrm _printFrm;
        private readonly RentalAgreementRpt _report;

        private Customer _customer;

        public RentalAgreementFrm(IRentalAgreementBl rentalAgreementBl, ICustomerBl customerBl, RentalAgreementDetailFacade detailFacade, CustomerView customerView, ProductSubcategoryView productSubcategoryView, PrintFrm printFrm, RentalAgreementRpt report)
        {   
            InitializeComponent();

            _customerBl = customerBl;
            _detailFacade = detailFacade;
            _customerView = customerView;
            _productSubcategoryView = productSubcategoryView;
            _printFrm = printFrm;
            _report = report;
            _rentalAgreementBl = rentalAgreementBl;
        }

        private void txtCustomerId_TextChanged(object sender, System.EventArgs e)
        {
            if (txtCustomerId.Text.Length != 6)
            {
                ClearCustomerData();

                dgvProductCategoryPrice.Rows.Clear();

                return;
            }

            _customer = _customerBl.Get(cust => cust.Id == txtCustomerId.Text).First();

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
                        txtCustomerId.Focus();

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
                foreach (var rentalAgreementDetail in customerRentalAgreement.Details)
                {
                    var idx = dgvProductCategoryPrice.Rows.Add();
                    var dgvRow = dgvProductCategoryPrice.Rows[idx];

                    dgvRow.Cells["ProductCategoryId"].Value = rentalAgreementDetail.Category.Id;
                    dgvRow.Cells["ProductCategory"].Value = rentalAgreementDetail.Category.Category;
                    dgvRow.Cells["ProductSubcategoryId"].Value = rentalAgreementDetail.Subcategory.Id;
                    dgvRow.Cells["ProductSubcategory"].Value = rentalAgreementDetail.Subcategory.Subcategory;
                    dgvRow.Cells["Price"].Value = rentalAgreementDetail.Price.ToString(CultureInfo.InvariantCulture);
                }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadProductSubcategoryView();
        }

        private void btnRemoveLine_Click(object sender, EventArgs e)
        {
            RemoveDetail();
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
            if (!ValidateRentalAgreement()) return;
            if (MessageBox.Show(@"Add new rental agreement?", @"Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            
            try
            {
                var newRentalAgreement = new RentalAgreement
                    {
                        Id = _rentalAgreementBl.GenerateNewId(),
                        Customer = _customer,
                        CutOffDate = int.Parse(numCutOffDate.Value.ToString(CultureInfo.InvariantCulture)),
                        Reference = txtReference.Text,
                        Sender = txtSender.Text,
                        AgreementDate = dtpAgreementDate.Value,
                        CreatedDate = DateTime.Now
                    };

                for (var i = 0; i < dgvProductCategoryPrice.Rows.Count; i++)
                {
                    newRentalAgreement.AddRentalDetails(new RentalAgreementDetail()
                        {
                            RentalAgreement = newRentalAgreement,
                            Category = _detailFacade.GetSingleCategory(dgvProductCategoryPrice.Rows[i].Cells["ProductCategoryId"].Value.ToString()),
                            Subcategory = _detailFacade.GetSingleSubcategory(dgvProductCategoryPrice.Rows[i].Cells["ProductSubcategoryId"].Value.ToString()),
                            Price = Double.Parse(dgvProductCategoryPrice.Rows[i].Cells["Price"].Value.ToString())
                        });
                }

                var message = _rentalAgreementBl.Save(newRentalAgreement);

                MessageBox.Show(message);
                 
                Print(newRentalAgreement, _report.ResourceName);

                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(TextBox))
                    {
                        control.Text = string.Empty;
                    }
                }

                dgvProductCategoryPrice.Rows.Clear();

                txtCustomerId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                if (dgvProductCategoryPrice.Rows.Count < 1)
                {
                    MessageBox.Show(@"Rental agreement need minimum of one detail");

                    dgvProductCategoryPrice.Focus();

                    return false;
                }
            }

            return true;
        }

        private void LoadCustomerView()
        {
            _customerView.ShowDialog();
            
            txtCustomerId.Text = _customerView.SelectedCustomer.Id;
            txtSender.Focus();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        private void LoadProductSubcategoryView()
        {
            _productSubcategoryView.ShowDialog();

            if (_productSubcategoryView.ProductSubcategory != null)
            {
                var productSubcategory = _productSubcategoryView.ProductSubcategory;
                var isUnique = true;

                foreach (DataGridViewRow row in dgvProductCategoryPrice.Rows)
                {
                    if (row.Cells["ProductCategoryId"].Value == null || row.Cells["ProductSubcategoryId"].Value == null) continue;

                    if (row.Cells["ProductCategoryId"].Value.ToString() == productSubcategory.Category.Id && row.Cells["ProductSubcategoryId"].Value.ToString() == productSubcategory.Id)
                    {
                        isUnique = false;
                    }
                }

                if (isUnique)
                {
                    dgvProductCategoryPrice.Rows.Add(productSubcategory.Category.Id,
                                                     productSubcategory.Category.Category, 
                                                     productSubcategory.Id,
                                                     productSubcategory.Subcategory, 
                                                     "0");
                }
                else
                {
                    MessageBox.Show(string.Format("Product category \'{0}\' subcategory \'{1}\' already added", productSubcategory.Category.Category, productSubcategory.Subcategory));
                }
            }
        }

        private void RemoveDetail()
        {
            if (dgvProductCategoryPrice.CurrentRow != null)
            {
                var productCategory = dgvProductCategoryPrice.CurrentRow.Cells["ProductCategory"].Value.ToString();
                var productSubcategory = dgvProductCategoryPrice.CurrentRow.Cells["ProductSubcategory"].Value.ToString();

                if (MessageBox.Show(string.Format("Remove detail category \'{0}\' and subcategory \'{1}\'?", productCategory, productSubcategory), @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvProductCategoryPrice.Rows.RemoveAt(dgvProductCategoryPrice.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show(@"No detail to delete");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    LoadCustomerView();
                    break;
                case Keys.F2:
                    LoadProductSubcategoryView();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Print(Entity dataSource, string reportFileName)
        {
            _printFrm.DataSource = dataSource;
            _printFrm.ReportFilename = reportFileName;

            _printFrm.ShowDialog();
        }
    }
}