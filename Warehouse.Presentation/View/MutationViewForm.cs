namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using Warehouse.Business.Model;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;
    using Warehouse.Presentation.Presenter;

    public partial class MutationViewForm : BaseForm, IMutationViewForm
    {
        private readonly MutationViewPresenter _presenter;

        private Customer _customer;
        private IList<RentalProduct> _rentalProducts;
        private IList<MutationIn> _mutationsIn;
        private IList<MutationOut> _mutationsOut;

        public MutationViewForm(MutationViewPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

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
                        dgvRentalProduct.Rows.Add(
                            rentalProduct.Id,
                            rentalProduct.ProductCategory.Id,
                            rentalProduct.ProductCategory.Category,
                            rentalProduct.ProductSubcategory.Id,
                            rentalProduct.ProductSubcategory.Subcategory,
                            rentalProduct.Brand,
                            rentalProduct.Description,
                            string.Format("{0:#,0}", rentalProduct.Stock)
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
            _presenter.GetCustomer(txtCustomerId.Text);
        }

        private void MutationViewForm_Load(object sender, EventArgs e)
        {
            _presenter.SetForm(this);
        }

        private void dgvRentalProduct_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvRentalProduct.CurrentRow != null && dgvRentalProduct.Rows.Count > 0)
            {
                _presenter.GetRentalProductMutationIn(dgvRentalProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                _presenter.GetRentalProductMutationOut(dgvRentalProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
            }
        }
    }
}