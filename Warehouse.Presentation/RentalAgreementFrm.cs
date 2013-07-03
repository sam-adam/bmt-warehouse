namespace Warehouse.Presentation
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Delegates;
    using Warehouse.Presentation.Print;
    using Warehouse.Presentation.View;

    public partial class RentalAgreementFrm : Form
    {
        private readonly IRentalAgreementBl _rentalAgreementBl;
        private readonly CustomerView _customerView;
        private readonly ProductSubcategoryView _productSubcategoryView;
        private readonly PrintFrm _printFrm;
        private readonly RentalAgreementRpt _report;

        private Customer _customer;

        #region Constructors
        public RentalAgreementFrm(IRentalAgreementBl rentalAgreementBl, CustomerView customerView, ProductSubcategoryView productSubcategoryView, PrintFrm printFrm, RentalAgreementRpt report)
        {   
            InitializeComponent();

            _customerView = customerView;
            _productSubcategoryView = productSubcategoryView;
            _printFrm = printFrm;
            _report = report;
            _rentalAgreementBl = rentalAgreementBl;
        }
        #endregion

        #region Events
        private void RentalAgreementFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtCustomerId_TextChanged(object sender, System.EventArgs e)
        {
            ClearCustomerData(txtCustomerId);

            if (txtCustomerId.Text.Length != 6) return;
            
            _customer = _rentalAgreementBl.GetCustomer(txtCustomerId.Text);

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
                        txtCustomerId.Clear();
                        txtCustomerId.Focus();
                    }
                }
                else
                {
                    SetCustomerData(_customer);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadProductSubcategoryView();
        }

        private void btnRemoveLine_Click(object sender, EventArgs e)
        {
            RemoveDetail();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
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
            if (MessageBox.Show(@"Add new rental agreement?", @"Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                var rentalAgreement = new RentalAgreement
                {
                    Id = _rentalAgreementBl.GenerateNewId(),
                    Customer = _customer,
                    CutOffDate = (int)numCutOffDate.Value,
                    Reference = txtReference.Text,
                    AgreementDate = dtpAgreementDate.Value,
                    CreatedDate = dtpTransactionDate.Value
                };

                foreach (DataGridViewRow row in dgvProductCategoryPrice.Rows)
                {
                    rentalAgreement.AddRentalDetails(new RentalAgreementDetail()
                        {
                            RentalAgreement = rentalAgreement,
                            Category = _rentalAgreementBl.GetCategory(row.Cells["ProductCategoryId"].Value.ToString()),
                            Subcategory = _rentalAgreementBl.GetSubcategory(row.Cells["ProductSubcategoryId"].Value.ToString()),
                            Price = Double.Parse(row.Cells["Price"].Value.ToString())
                        });
                }

                var message = _rentalAgreementBl.Save(rentalAgreement);

                MessageBox.Show(message);

                Print(rentalAgreement, _report.ResourceName);

                ClearCustomerData();

                txtCustomerId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvProductCategoryPrice_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductCategoryPrice.CurrentRow != null && dgvProductCategoryPrice.CurrentRow.Cells["IsRemovable"] != null)
            {
                var isRemovable = dgvProductCategoryPrice.CurrentRow.Cells["IsRemovable"].Value;

                btnRemoveLine.Enabled = isRemovable != null && (bool)isRemovable;
            }
        }
        #endregion

        #region Overrides
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
        #endregion
        
        #region Functions
        public void ViewRentalAgreement(RentalAgreementSelectEventArgs e)
        {
            if (e.RentalAgreement != null)
            {
                SetViewMode();
            }            
        }

        private void ClearCustomerData(object sender = null, Control.ControlCollection controlCollection = null)
        {
            _customer = null;

            if (controlCollection == null) controlCollection = Controls;

            foreach (Control control in controlCollection)
            {
                if (control is TextBox && !ReferenceEquals(sender, control))
                {
                    var txtControl = control as TextBox;

                    txtControl.Clear();
                }

                if (control.Controls.Count > 0) ClearCustomerData(sender, control.Controls);
            }

            dgvProductCategoryPrice.Rows.Clear();
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
            numCutOffDate.Value = 25;

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
                    dgvRow.Cells["IsRemovable"].Value = false;
                }
            }
        }

        private void LoadCustomerView()
        {
            _customerView.CustomerSelected += CustomerView_CustomerSelected;

            _customerView.ShowDialog();
        }

        private void CustomerView_CustomerSelected(object sender, CustomerSelectedEventArgs e)
        {
            if (e.Customer != null)
            {
                txtCustomerId.Text = e.Customer.Id;
            }
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
                                                     "0",
                                                     true);
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

        private void Print(RentalAgreement rentalAgreement, string reportFileName)
        {
            _printFrm.RecordSelectionFormula = "{tbl_trrentalagreement1.id_rentalagreement}='" + rentalAgreement.Id + "'";
            _printFrm.ReportFilename = reportFileName;

            _printFrm.ShowDialog();
        }

        private void SetViewMode()
        {
            btnViewCustomer.Enabled = false;
            btnAdd.Enabled = false;
            btnRemoveLine.Enabled = false;
            txtCustomerId.ReadOnly = true;
            txtReference.ReadOnly = true;
            numCutOffDate.ReadOnly = true;
            dgvProductCategoryPrice.ReadOnly = true;
            tssHelp.Visible = false;
            tssHelpCategorySelection.Visible = false;
            tssHelpCustomerSelection.Visible = false;
        }
        #endregion
    }
}