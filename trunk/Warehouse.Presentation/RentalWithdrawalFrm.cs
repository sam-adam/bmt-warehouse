namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.View;

    public partial class RentalWithdrawalFrm : Form
    {
        private readonly CustomerView _customerView;
        private readonly IRentalWithdrawalBl _rentalWithdrawalBl;

        public RentalWithdrawalFrm(IRentalWithdrawalBl rentalWithdrawalBl, CustomerView customerView)
        {
            _rentalWithdrawalBl = rentalWithdrawalBl;
            _customerView = customerView;

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
                    SetRentalItems(customer);

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
                        var withdrawalDetail = new RentalWithdrawalDetail();

                        withdrawalDetail.RentalWithdrawal = withdrawal;
                        withdrawalDetail.ProductCategory = _rentalWithdrawalBl.GetCategory(row.Cells["ProductCategoryId"].Value.ToString());
                        withdrawalDetail.ProductSubcategory = _rentalWithdrawalBl.GetSubcategory(row.Cells["ProductSubcategoryId"].Value.ToString());
                        withdrawalDetail.Brand = row.Cells["Brand"].Value.ToString();
                        withdrawalDetail.Description = row.Cells["Description"].Value.ToString();
                        withdrawalDetail.Quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                        withdrawalDetail.Remark = row.Cells["Remark"].Value.ToString();

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
        
        private void SetRentalItems(Customer customer)
        {
            var rentalItems = _rentalWithdrawalBl.GetRentalItems(customer.Id);

            dgvRentalWithdrawalDetail.Rows.Clear();

            if (rentalItems != null)
            {
                foreach (var rentalItem in rentalItems)
                {
                    dgvRentalWithdrawalDetail.Rows.Add(rentalItem.ProductCategory.Id,
                                                        rentalItem.ProductCategory.Category,
                                                        rentalItem.ProductSubcategory.Id,
                                                        rentalItem.ProductSubcategory.Subcategory,
                                                        rentalItem.Brand,
                                                        rentalItem.Description,
                                                        rentalItem.Quantity,
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
