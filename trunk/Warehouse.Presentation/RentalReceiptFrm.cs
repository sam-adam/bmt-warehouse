namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Warehouse.Business.Facade;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.View;

    public partial class RentalReceiptFrm : Form
    {
        private readonly RentalReceiptFacade _facade;
        private readonly CustomerView _customerView;
        private readonly RentalAgreementView _rentalAgreementView;
        private readonly RentalAgreementDetailView _rentalAgreementDetailView;

        private RentalAgreement _rentalAgreement;

        public RentalReceiptFrm(RentalReceiptFacade facade, CustomerView customerView, RentalAgreementView rentalAgreementView, RentalAgreementDetailView rentalAgreementDetailView)
        {
            InitializeComponent();

            _facade = facade;
            _customerView = customerView;
            _rentalAgreementView = rentalAgreementView;
            _rentalAgreementDetailView = rentalAgreementDetailView;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    LoadRentalAgreementView();
                    break;
                case Keys.F2:
                    LoadCustomerView();                    
                    break;
                case Keys.F3:
                    LoadRentalAgreementDetailView();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtAgreementId_TextChanged(object sender, EventArgs e)
        {
            dgvRentalReceiptDetail.Rows.Clear();

            if (txtAgreementId.Text.Length != 15)
            {
                if (txtCustomerId.Text != string.Empty) ClearForm(txtAgreementId);

                return;
            }

            _rentalAgreement = _facade.GetRentalAgreement(txtAgreementId.Text);

            if (_rentalAgreement == null)
            {
                if (txtCustomerId.Text != string.Empty) ClearForm(txtAgreementId);

                return;
            }

            if (_rentalAgreement.Status == "ACTIVE")
            {
                FillData(_rentalAgreement);

                txtReference.Focus();
            }
            else
            {
                MessageBox.Show(string.Format("Rental agreement : \'{0}\' is not active", _rentalAgreement.Id));

                if (txtCustomerId.Text != string.Empty) ClearForm(txtAgreementId);
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerId.Text.Length != 6)
            {
                ClearForm(txtCustomerId);

                return;
            }

            var rentalAgreement = _facade.GetCustomerRentalAgreement(txtCustomerId.Text);

            if (rentalAgreement == null)
            {
                MessageBox.Show(string.Format("Customer \'{0}\' does not have an active agreement", txtCustomerId.Text));

                txtCustomerId.Focus();

                ClearForm(txtCustomerId);

                return;
            }

            if (rentalAgreement.Status == "ACTIVE")
            {
                FillData(rentalAgreement);
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

        private void btnViewRentalAgreement_Click(object sender, EventArgs e)
        {
            LoadRentalAgreementView();
        }

        private void FillData(RentalAgreement rentalAgreement)
        {
            txtAgreementId.Text = rentalAgreement.Id;
            txtAgreementSales.Text = rentalAgreement.CreatedBy.Id;
            txtAgreementSalesName.Text = rentalAgreement.CreatedBy.Name;
            txtCustomerTitle.Text = rentalAgreement.Customer.Title;
            txtCustomerId.Text = rentalAgreement.Customer.Id;
            txtCustomerName.Text = rentalAgreement.Customer.Name;
            txtCustomerPhone.Text = rentalAgreement.Customer.Phone;
            txtCustomerAddress.Text = rentalAgreement.Customer.Address1 + Environment.NewLine +
                                      rentalAgreement.Customer.Address2 + Environment.NewLine +
                                      rentalAgreement.Customer.Address3;
            txtCustomerEmail.Text = rentalAgreement.Customer.Email ?? "";
        }

        private void ClearForm(object sender)
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(TextBox) && !ReferenceEquals(control, sender))
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void LoadCustomerView()
        {
            _customerView.ShowDialog();

            txtCustomerId.Text = _customerView.SelectedCustomer.Id;
        }

        private void LoadRentalAgreementView()
        {
            _rentalAgreementView.ShowDialog();
            
            txtAgreementId.Text = _rentalAgreementView.SelectedRentalAgreement.Id;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRentalReceipt()) return;
            if (MessageBox.Show(@"Add new rental receipt?", @"Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var newRentalReceipt = new RentalReceipt()
                {
                    Id = _facade.GetNewId(),
                    RentalAgreement = _rentalAgreement,
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
                                Brand = row.Cells["Brand"].Value.ToString(),
                                Customer = _rentalAgreement.Customer,
                                Description = row.Cells["Description"].Value.ToString(),
                                ProductCategory = _facade.GetCategory(row.Cells["ProductCategoryId"].Value.ToString()),
                                ProductSubcategory = _facade.GetSubcategory(row.Cells["ProductSubcategoryId"].Value.ToString()),
                            },
                        Remark = row.Cells["Remark"].Value.ToString(),
                        Quantity = int.Parse(row.Cells["Quantity"].Value.ToString()),
                    });   
            }

            var message = _facade.Save(newRentalReceipt);

            MessageBox.Show(message);

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = string.Empty;
                }
            }

            dgvRentalReceiptDetail.Rows.Clear();

            txtAgreementId.Focus();
        }

        private bool ValidateRentalReceipt()
        {
            if (_rentalAgreement == null)
            {
                MessageBox.Show(@"No rental agreement is selected");

                return false;
            }

            if (string.IsNullOrEmpty(txtReference.Text))
            {
                MessageBox.Show(@"External reference cannot be empty");

                return false;
            }

            foreach (DataGridViewRow row in dgvRentalReceiptDetail.Rows)
            {
                if (row.Cells["Brand"].Value == null || row.Cells["Description"].Value == null || int.Parse(row.Cells["Quantity"].Value.ToString()) < 1)
                {
                    MessageBox.Show(@"Rental detail data is incomplete");

                    return false;
                }
            }

            return true;
        }
    }
}
