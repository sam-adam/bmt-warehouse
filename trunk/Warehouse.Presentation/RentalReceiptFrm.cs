namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Print;
    using Warehouse.Presentation.View;

    public partial class RentalReceiptFrm : Form
    {
        private readonly IRentalReceiptBl _receiptBl;
        private readonly CustomerView _customerView;
        private readonly RentalAgreementDetailView _rentalAgreementDetailView;
        private readonly PrintFrm _printFrm;
        private readonly RentalReceiptRpt _report;
        private readonly LoadingReceiptRpt _loadingReceipt;

        private RentalAgreement _rentalAgreement;

        #region Constructors
        public RentalReceiptFrm(CustomerView customerView, RentalAgreementDetailView rentalAgreementDetailView, PrintFrm printFrm, RentalReceiptRpt report, IRentalReceiptBl receiptBl, LoadingReceiptRpt loadingReceipt)
        {
            InitializeComponent();

            _customerView = customerView;
            _rentalAgreementDetailView = rentalAgreementDetailView;
            _printFrm = printFrm;
            _report = report;
            _receiptBl = receiptBl;
            _loadingReceipt = loadingReceipt;
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
                    LoadRentalAgreementDetailView();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Events
        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            ClearForm(txtCustomerId);

            if (txtCustomerId.Text.Length != 6) return;

            _rentalAgreement = _receiptBl.GetCustomerActiveAgreement(txtCustomerId.Text);

            if (_rentalAgreement != null && _rentalAgreement.Status == "ACTIVE")
            {
                FillData(_rentalAgreement);
            }
            else
            {
                MessageBox.Show(string.Format("Customer \'{0}\' does not have an active agreement", txtCustomerId.Text));

                txtCustomerId.Focus();

                ClearForm(txtCustomerId);
            }
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadRentalAgreementDetailView();
        }

        private void btnRemoveLine_Click(object sender, EventArgs e)
        {
            var tempCurrentRow = dgvRentalReceiptDetail.CurrentRow;

            if (tempCurrentRow != null && dgvRentalReceiptDetail.Rows.Count > 0)
            {
                dgvRentalReceiptDetail.Rows.RemoveAt(tempCurrentRow.Index);
            }
            else
            {
                MessageBox.Show(@"No detail selected");
            }
        }

        private void dgvRentalReceiptDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvRentalReceiptDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvRentalReceiptDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    dgvRentalReceiptDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
                }
            }
        }

        private void btnAddLoading_Click(object sender, EventArgs e)
        {
            dgvRentalReceiptLoadingDetail.Rows.Add();

            if (btnRemoveLoading.Enabled == false)
            {
                btnRemoveLoading.Enabled = true;
            }
        }

        private void btnRemoveLoading_Click(object sender, EventArgs e)
        {
            if (dgvRentalReceiptLoadingDetail.CurrentRow != null)
            {
                var curIdx = dgvRentalReceiptLoadingDetail.CurrentRow.Index;

                dgvRentalReceiptLoadingDetail.Rows.RemoveAt(curIdx);

                if (dgvRentalReceiptLoadingDetail.Rows.Count == 0)
                {
                    btnRemoveLoading.Enabled = false;
                }
            }
        }

        private void dgvRentalReceiptLoadingDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvRentalReceiptLoadingDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvRentalReceiptLoadingDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    dgvRentalReceiptLoadingDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(@"Add new rental receipt?", @"Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                var newRentalReceipt = new RentalReceipt()
                {
                    Id = _receiptBl.GenerateNewId(),
                    RentalAgreement = _rentalAgreement,
                    Sender = txtSender.Text,
                    Reference = txtReference.Text,
                    ReceiptDate = dtpRentalDate.Value,
                };

                foreach (DataGridViewRow row in dgvRentalReceiptDetail.Rows)
                {
                    newRentalReceipt.AddDetail(new RentalReceiptDetail()
                    {
                        RentalReceipt = newRentalReceipt,
                        RentalProduct = new RentalProduct()
                        {
                            Brand = row.Cells["Brand"].Value != null ? row.Cells["Brand"].Value.ToString() : null,
                            Customer = _rentalAgreement.Customer,
                            Description = row.Cells["Description"].Value != null ? row.Cells["Description"].Value.ToString() : null,
                            ProductCategory = row.Cells["ProductCategoryId"].Value != null ? _receiptBl.GetCategory(row.Cells["ProductCategoryId"].Value.ToString()) : null,
                            ProductSubcategory = row.Cells["ProductSubcategoryId"].Value != null ? _receiptBl.GetSubcategory(row.Cells["ProductSubcategoryId"].Value.ToString()) : null,
                        },
                        Remark = row.Cells["Remark"].Value != null ? row.Cells["Remark"].Value.ToString() : string.Empty,
                        Quantity = row.Cells["Quantity"].Value != null ? int.Parse(row.Cells["Quantity"].Value.ToString()) : 0,
                    });
                }

                foreach (DataGridViewRow row in dgvRentalReceiptLoadingDetail.Rows)
                {
                    newRentalReceipt.AddLoadingDetail(new RentalReceiptLoadingDetail()
                    {
                        RentalReceipt = newRentalReceipt,
                        Description = row.Cells["LoadingDescription"].Value.ToString(),
                        Price = Double.Parse(row.Cells["LoadingPrice"].Value.ToString()),
                    });
                }

                var message = _receiptBl.Save(newRentalReceipt);

                MessageBox.Show(message);

                Print(newRentalReceipt, _report.ResourceName);
                Print(newRentalReceipt, _loadingReceipt.ResourceName);

                ClearForm();

                txtCustomerId.Focus();

                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Functions
        private void FillData(RentalAgreement rentalAgreement)
        {
            txtRentalAgreement.Text = rentalAgreement.Id;
            txtCustomerTitle.Text = rentalAgreement.Customer.Title;
            txtCustomerId.Text = rentalAgreement.Customer.Id;
            txtCustomerName.Text = rentalAgreement.Customer.Name;
            txtCustomerPhone.Text = rentalAgreement.Customer.Phone;
            txtCustomerAddress.Text = rentalAgreement.Customer.Address1 + Environment.NewLine +
                                      rentalAgreement.Customer.Address2 + Environment.NewLine +
                                      rentalAgreement.Customer.Address3;
            txtCustomerEmail.Text = rentalAgreement.Customer.Email ?? "";
        }

        private void ClearForm(object sender = null, Control.ControlCollection controlCollection = null)
        {
            _rentalAgreement = null;

            if (controlCollection == null) controlCollection = Controls;

            foreach (Control control in controlCollection)
            {
                if (control is TextBox && !ReferenceEquals(sender, control))
                {
                    var txtControl = control as TextBox;

                    txtControl.Clear();
                }

                if (control.Controls.Count > 0) ClearForm(sender, control.Controls);
            }

            dgvRentalReceiptDetail.Rows.Clear();
            dgvRentalReceiptLoadingDetail.Rows.Clear();
        }

        private void LoadCustomerView()
        {
            _customerView.ShowDialog();

            if (_customerView.Customer != null)
            {
                txtCustomerId.Text = _customerView.Customer.Id;   
            }
        }

        private void LoadRentalAgreementDetailView()
        {
            if (_rentalAgreement != null)
            {
                _rentalAgreementDetailView.RentalAgreement = _rentalAgreement;
                _rentalAgreementDetailView.ShowDialog();

                var rentalDetail = _rentalAgreementDetailView.RentalAgreementDetail;

                if (rentalDetail != null)
                {
                    var idx = dgvRentalReceiptDetail.Rows.Add(rentalDetail.Category.Id, rentalDetail.Category.Category, rentalDetail.Subcategory.Id, rentalDetail.Subcategory.Subcategory);

                    dgvRentalReceiptDetail.Focus();
                    dgvRentalReceiptDetail.CurrentCell = dgvRentalReceiptDetail.Rows[idx].Cells["Brand"];
                }   
            }
            else
            {
                MessageBox.Show(@"No rental agreement selected");
            }
        }

        private void Print(RentalReceipt rentalReceipt, string reportFileName)
        {
            _printFrm.RecordSelectionFormula = "{tbl_trrentalreceipt1.id_rentalreceipt}='" + rentalReceipt.Id + "'";
            _printFrm.ReportFilename = reportFileName;

            _printFrm.ShowDialog();
        }
        #endregion
    }
}