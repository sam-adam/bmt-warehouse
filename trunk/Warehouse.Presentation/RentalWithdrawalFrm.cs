namespace Warehouse.Presentation
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Print;
    using Warehouse.Presentation.View;

    public partial class RentalWithdrawalFrm : Form
    {
        private readonly CustomerView _customerView;
        private readonly IRentalWithdrawalBl _rentalWithdrawalBl;
        private readonly IRentalProductBl _rentalProductBl;
        private readonly PrintFrm _printFrm;
        private readonly RentalWithdrawalRpt _report;

        private RentalWithdrawal _rentalWithdrawal;

        #region Constructors
        public RentalWithdrawalFrm(IRentalWithdrawalBl rentalWithdrawalBl, CustomerView customerView, IRentalProductBl rentalProductBl, PrintFrm printFrm, RentalWithdrawalRpt report)
        {
            _rentalWithdrawalBl = rentalWithdrawalBl;
            _customerView = customerView;
            _rentalProductBl = rentalProductBl;
            _printFrm = printFrm;
            _report = report;

            InitializeComponent();
        }
        #endregion

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                LoadCustomerView();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Events
        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            ClearForm(txtCustomerId);

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
            try
            {
                if (MessageBox.Show(@"Create new rental withdrawal?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _rentalWithdrawal = new RentalWithdrawal();

                    var customer = _rentalWithdrawalBl.GetCustomer(txtCustomerId.Text);

                    _rentalWithdrawal.Customer = customer;
                    _rentalWithdrawal.CreatedDate = dtpTransactionDate.Value;
                    _rentalWithdrawal.WithdrawalDate = dtpRentalDate.Value;
                    _rentalWithdrawal.Reference = txtReference.Text;

                    foreach (DataGridViewRow row in dgvItemDetail.Rows)
                    {
                        if (int.Parse(row.Cells["Quantity"].Value.ToString()) > 0)
                        {
                            var product = _rentalProductBl.Get(row.Cells["ProductId"].Value.ToString()).First();

                            var withdrawalDetail = new RentalWithdrawalDetail()
                            {
                                RentalWithdrawal = _rentalWithdrawal,
                                RentalProduct = product,
                                Quantity = int.Parse(row.Cells["Quantity"].Value.ToString())
                            };

                            _rentalWithdrawal.AddDetail(withdrawalDetail);
                        }
                    }

                    foreach (DataGridViewRow row in dgvUnloadingDetail.Rows)
                    {
                        if (row.Cells["UnloadingDescription"].Value != null && row.Cells["UnloadingPrice"].Value != null)
                        {
                            var unloadingDetail = new RentalWithdrawalUnloadingDetail()
                            {
                                RentalWithdrawal = _rentalWithdrawal,
                                Description = row.Cells["UnloadingDescription"].Value.ToString(),
                                Price = Double.Parse(row.Cells["UnloadingPrice"].Value.ToString())
                            };

                            _rentalWithdrawal.AddUnloadingDetail(unloadingDetail);
                        }
                    }

                    var message = _rentalWithdrawalBl.Save(_rentalWithdrawal);

                    MessageBox.Show(message);

                    Print(_rentalWithdrawal, _report.ResourceName);

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRentalWithdrawalDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvItemDetail.CurrentRow;

            if (currentRow != null)
            {
                var stockColumn = dgvItemDetail.Columns["Stock"];
                var quantityColumn = dgvItemDetail.Columns["Quantity"];

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

        private void dgvUnloadingDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveUnloading.Enabled = dgvUnloadingDetail.Rows.Count > 0;
        }

        private void dgvUnloadingDetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btnRemoveUnloading.Enabled = dgvUnloadingDetail.Rows.Count > 0;
        }

        private void btnRemoveUnloading_Click(object sender, EventArgs e)
        {
            if (dgvUnloadingDetail.CurrentRow != null)
            {
                var rowIdx = dgvUnloadingDetail.CurrentRow.Index;

                dgvUnloadingDetail.Rows.RemoveAt(rowIdx);
            }
        }

        private void btnAddUnloading_Click(object sender, EventArgs e)
        {
            dgvUnloadingDetail.Rows.Add();
        }
        #endregion

        #region Functions
        private void LoadCustomerView()
        {
            _customerView.ShowDialog();

            if (_customerView.Customer != null)
            {
                txtCustomerId.Text = _customerView.Customer.Id;   
            }
        }

        private void ClearForm(object sender = null, Control.ControlCollection controlCollection = null)
        {
            _rentalWithdrawal = null;

            if (controlCollection == null) controlCollection = Controls;

            foreach (Control control in controlCollection)
            {
                if (control is TextBox && !ReferenceEquals(control, sender))
                {
                    var txtControl = control as TextBox;

                    txtControl.Clear();
                }

                if (control.Controls.Count > 0) ClearForm(sender, control.Controls);
            }

            dgvItemDetail.Rows.Clear();
            dgvUnloadingDetail.Rows.Clear();
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

            dgvItemDetail.Rows.Clear();

            if (rentalProducts != null)
            {
                foreach (var rentalProduct in rentalProducts)
                {
                    dgvItemDetail.Rows.Add(rentalProduct.Id,
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

        private void Print(RentalWithdrawal rentalWithdrawal, string reportFileName)
        {
            _printFrm.RecordSelectionFormula = "{tbl_trrentalwithdrawal1.id_rentalwithdrawal}='" + rentalWithdrawal.Id + "'";
            _printFrm.ReportFilename = reportFileName;

            _printFrm.ShowDialog();
        }
        #endregion

        private void dgvUnloadingDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUnloadingDetail.CurrentRow != null)
            {
                dgvUnloadingDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    dgvUnloadingDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
            }
        }
    }
}