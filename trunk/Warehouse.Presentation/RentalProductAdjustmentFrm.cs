namespace Warehouse.Presentation
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;
    using Warehouse.Presentation.Delegates;
    using Warehouse.Presentation.Presenter;
    using Warehouse.Presentation.View;

    public partial class RentalProductAdjustmentFrm : BaseForm, IRentalProductAdjustmentForm
    {
        private readonly RentalProductAdjusmentPresenter _presenter;
        private readonly CustomerView _customerView;
        private List<RentalProductAdjusmentDetail> _details;
        private Customer _customer;

        public RentalProductAdjustmentFrm(RentalProductAdjusmentPresenter presenter, CustomerView customerView)
        {
            _presenter = presenter;
            _customerView = customerView;

            _customerView.CustomerSelected += CustomerView_CustomerSelected;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;

                CleanForm(txtCustomerId);

                if (_customer != null)
                {
                    txtCustomerName.Text = _customer.Name;
                    txtCustomerEmail.Text = _customer.Email;
                    txtCustomerPhone.Text = _customer.Phone;
                    txtCustomerTitle.Text = _customer.Title;
                    txtCustomerAddress.Text = _customer.Address1 + Environment.NewLine
                                              + _customer.Address2 + Environment.NewLine
                                              + _customer.Address3;
                }
            }
        }

        public string CustomerIdInput
        {
            set { txtCustomerId.Text = value; }
            get { return txtCustomerId.Text; } 
        }

        public List<RentalProductAdjusmentDetail> Details
        {
            get { return _details; }

            set
            {
                _details = value;

                if (_details != null)
                {
                    foreach (var detail in value)
                    {
                        dgvRentalProductAdjustmentDetail.Rows.Add(
                            detail.RentalProduct.Id,
                            detail.RentalProduct.ProductCategory.Id,
                            detail.RentalProduct.ProductCategory.Category,
                            detail.RentalProduct.ProductSubcategory.Id,
                            detail.RentalProduct.ProductSubcategory.Subcategory,
                            detail.RentalProduct.Brand,
                            detail.RentalProduct.Description,
                            detail.PreviousStock,
                            detail.AdjustedStock
                        );
                    }
                }
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            _presenter.GetCustomer();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        private void LoadCustomerView()
        {
            _customerView.ShowDialog();
        }

        private void CustomerView_CustomerSelected(object sender, CustomerSelectedEventArgs e)
        {
            if (e.Customer != null)
            {
                txtCustomerId.Text = e.Customer.Id;
            }
        }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Create new rental products adjustment?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _presenter.Save();

                    CleanForm();

                    Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void dgvRentalProductAdjustmentDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRentalProductAdjustmentDetail.Rows.Count > 0)
            {
                var rentalProductId = dgvRentalProductAdjustmentDetail.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                var newAdjustedStock = int.Parse(dgvRentalProductAdjustmentDetail.Rows[e.RowIndex].Cells["AdjustedStock"].Value.ToString());

                _details.Find(prod => prod.RentalProduct.Id == rentalProductId).AdjustedStock = newAdjustedStock;   
            }
        }
    }
}
