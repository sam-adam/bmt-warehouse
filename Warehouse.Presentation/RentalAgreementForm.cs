namespace Warehouse.Presentation
{
    using System;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;
    using Warehouse.Presentation.Presenter;

    public partial class RentalAgreementForm : BaseForm, IRentalAgreementForm
    {
        private readonly RentalAgreementPresenter _presenter;
        private RentalAgreement _rentalAgreement;
        private ViewMode _viewMode;
        private Customer _customer;

        public RentalAgreementForm(RentalAgreementPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        private void RentalAgreement_Load(object sender, EventArgs e)
        {

        }

        #region IRentalAgreementForm Members
        public string CustomerIdInput
        {
            get { return txtCustomerId.Text; }
            set { txtCustomerId.Text = value; }
        }
        public string ExternalReferenceInput
        {
            get { return txtReference.Text; }
            set { txtReference.Text = value; }
        }
        public DateTime RentalAgreementDateInput
        {
            get { return dtpAgreementDate.Value; }
            set { dtpAgreementDate.Value = value; }
        }

        public Customer Customer
        {
            get
            {
                return _customer;
            }

            set
            {
                _customer = value;

                if (_customer != null)
                {
                    txtCustomerTitle.Text = _customer.Title;
                    txtCustomerName.Text = _customer.Name;
                    txtCustomerPhone.Text = _customer.Phone;
                }
            }
        }

        public RentalAgreement RentalAgreement
        {
            get { return _rentalAgreement; }
            set { _rentalAgreement = value; }
        }
        #endregion

        public ViewMode ViewMode
        {
            get
            {
                return _viewMode;
            }

            set
            {
                _viewMode = value;

                switch (_viewMode)
                {
                    case ViewMode.View:
                        txtCustomerId.ReadOnly = true;
                        txtReference.ReadOnly = true;
                        dtpAgreementDate.Enabled = false;
                        numCutOffDate.ReadOnly = true;
                        pnlAgreementDetailAction.Visible = false;
                        btnViewCustomer.Enabled = false;
                        break;
                }
            }
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            _presenter.GetCustomerById();
        }
    }
}
