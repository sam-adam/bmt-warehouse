namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Warehouse.Business;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.View;

    public partial class RentalReceiptFrm : Form
    {
        private readonly RentalReceiptBl _rentalReceiptBl;
        private readonly CustomerView _customerView;

        private RentalAgreement _rentalAgreement;

        public RentalReceiptFrm(RentalReceiptBl rentalReceiptBl, CustomerView customerView)
        {
            InitializeComponent();

            _customerView = customerView;
            _rentalReceiptBl = rentalReceiptBl;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                LoadCustomerView();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtAgreementId_TextChanged(object sender, EventArgs e)
        {
            if (txtAgreementId.Text.Length != 15)
            {
                if (txtCustomerId.Text != string.Empty) ClearForm(txtAgreementId);

                return;
            }

            _rentalAgreement = _rentalReceiptBl.GetRentalAgreement(txtAgreementId.Text);

            if (_rentalAgreement == null)
            {
                if (txtCustomerId.Text != string.Empty) ClearForm(txtAgreementId);

                return;
            }

            if (_rentalReceiptBl.IsActiveRentalAgreement(_rentalAgreement))
            {
                FillData(_rentalAgreement);
            }
            else
            {
                MessageBox.Show(string.Format("Rental agreement with id \'{0}\' is no longer active", _rentalAgreement.Id));

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

            _rentalAgreement = _rentalReceiptBl.GetCustomerRentalAgreement(txtCustomerId.Text);

            if (_rentalAgreement == null)
            {
                MessageBox.Show(string.Format("Customer \'{0}\' does not have an active agreement", txtCustomerId.Text));

                txtCustomerId.Focus();

                ClearForm(txtCustomerId);

                return;
            }

            if (_rentalReceiptBl.IsActiveRentalAgreement(_rentalAgreement))
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

        private void btnViewRentalAgreement_Click(object sender, EventArgs e)
        {

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
    }
}
