namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Warehouse.Business.Model;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;
    using Warehouse.Presentation.Delegates;
    using Warehouse.Presentation.Presenter;

    public partial class MutationViewForm : BaseForm, IMutationViewForm
    {
        private readonly MutationViewPresenter _presenter;
        private readonly CustomerView _customerView;

        private Customer _customer;
        private IList<RentalProduct> _rentalProducts;
        private IList<MutationIn> _mutationsIn;
        private IList<MutationOut> _mutationsOut;

        public MutationViewForm(MutationViewPresenter presenter, CustomerView customerView)
        {
            _presenter = presenter;
            _customerView = customerView;

            InitializeComponent();
        }

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    LoadCustomerView();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region IMutationView Members
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;

                CleanForm(txtCustomerId);

                if (_customer != null)
                {
                    txtCustomerId.Text = Customer.Id;
                    txtCustomerTitle.Text = Customer.Title;
                    txtCustomerName.Text = Customer.Name;
                    txtCustomerPhone.Text = Customer.Phone;
                    txtCustomerAddress.Text = Customer.Address1 + Environment.NewLine
                                              + Customer.Address2 + Environment.NewLine
                                              + Customer.Address3;
                    txtCustomerEmail.Text = Customer.Email;
                }
            }
        }

        public string CustomerIdInput
        {
            get { return txtCustomerId.Text; }
            set { txtCustomerId.Text = value; }
        }

        public string SelectedProductId
        {
            get
            {
                return dgvRentalProduct.CurrentRow != null
                           ? dgvRentalProduct.CurrentRow.Cells["ProductId"].Value.ToString()
                           : null;
            }
        }

        public DateTime MutationFrom { get { return dtpMutationFrom.Value; } }
        public DateTime MutationTo { get { return dtpMutationTo.Value; } }

        public IList<RentalProduct> RentalProducts
        {
            set
            {
                _rentalProducts = value;

                dgvRentalProduct.Rows.Clear();
                
                if (_rentalProducts != null)
                {
                    foreach (var rentalProduct in _rentalProducts)
                    {
                        var beginingBalance = _presenter.GetProductBalance(rentalProduct.Id);

                        dgvRentalProduct.Rows.Add(
                            rentalProduct.Id,
                            rentalProduct.ProductCategory.Id,
                            rentalProduct.ProductCategory.Category,
                            rentalProduct.ProductSubcategory.Id,
                            rentalProduct.ProductSubcategory.Subcategory,
                            rentalProduct.Brand,
                            rentalProduct.Description,
                            string.Format("{0:#,0}", rentalProduct.Stock),
                            string.Format("{0:#,0}", beginingBalance)
                        );   
                    }
                }
            }
        } 

        public IList<MutationIn> MutationsIn
        {
            set
            {
                _mutationsIn = value;

                dgvMutation.Rows.Clear();

                if (_mutationsIn != null)
                {
                    foreach (var mutationIn in _mutationsIn)
                    {
                        var rowIdx = dgvMutation.Rows.Add(mutationIn.MutationType, mutationIn.RentalReceipt.Id, mutationIn.RentalReceipt.ReceiptDate, string.Format("{0:#,0}", mutationIn.Quantity));

                        dgvMutation.Rows[rowIdx].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }

                    dgvMutation.Sort(dgvMutation.Columns["MutationDate"], ListSortDirection.Descending);
                }
            }
        }

        public IList<MutationOut> MutationsOut
        {
            set
            {
                _mutationsOut = value;

                if (_mutationsOut != null)
                {
                    foreach (var mutationOut in _mutationsOut)
                    {
                        var rowIdx = dgvMutation.Rows.Add(mutationOut.MutationType, mutationOut.RentalWithdrawal.Id, mutationOut.RentalWithdrawal.WithdrawalDate, string.Format("{0:#,0}", mutationOut.Quantity));

                        dgvMutation.Rows[rowIdx].DefaultCellStyle.BackColor = Color.Coral;
                    }

                    dgvMutation.Sort(dgvMutation.Columns["MutationDate"], ListSortDirection.Descending);
                }
            }
        }

        #endregion

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            _presenter.GetMutation();
        }

        private void MutationViewForm_Load(object sender, EventArgs e)
        {
            _presenter.SetForm(this);
        }

        private void dgvRentalProduct_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvRentalProduct.CurrentRow != null && dgvRentalProduct.Rows.Count > 0)
            {
                _presenter.GetRentalProductMutations(dgvRentalProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
            }
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        private void LoadCustomerView()
        {
            _customerView.CustomerSelected += CustomerView_CustomerSelected;

            _customerView.ShowDialog();
        }

        private void CustomerView_CustomerSelected(object sender, CustomerSelectedEventArgs e)
        {
            Customer = e.Customer;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void dtpMutationFrom_ValueChanged(object sender, EventArgs e)
        {
            _presenter.GetMutation();
        }

        private void dtpMutationTo_ValueChanged(object sender, EventArgs e)
        {
            _presenter.GetMutation();
        }
    }
}