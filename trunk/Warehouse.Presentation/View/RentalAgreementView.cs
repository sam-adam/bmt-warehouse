namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public partial class RentalAgreementView : Form
    {
        private readonly IRentalAgreementBl _rentalAgreementBl;

        private IList<RentalAgreement> _rentalAgreements;

        public RentalAgreement SelectedRentalAgreement { get; private set; }

        public RentalAgreementView(IRentalAgreementBl rentalAgreementBl)
        {
            _rentalAgreementBl = rentalAgreementBl;

            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (SelectedRentalAgreement == null)
                {
                    MessageBox.Show(@"No selected rental agreement");
                }
                else
                {
                    Close();   
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RentalAgreementView_Load(object sender, EventArgs e)
        {
            cboCriteria.SelectedIndex = 0;

            RefreshList();
        }

        private void RefreshList()
        {
            dgvRentalAgreement.Rows.Clear();
            dgvRentalAgreementDetail.Rows.Clear();

            if (txtKeyword.Text == string.Empty)
            {
                _rentalAgreements = _rentalAgreementBl.GetAllActive();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "RentalAgreement Id" :
                        _rentalAgreements = _rentalAgreementBl.GetActive(rent => rent.Id.Contains(txtKeyword.Text));
                        break;
                    case "Customer" :
                        _rentalAgreements = _rentalAgreementBl.GetActive(rent => rent.Customer.Id.Contains(txtKeyword.Text));
                        break;
                    case "Agreement Date" :
                        _rentalAgreements = _rentalAgreementBl.GetActive(rent => rent.AgreementDate.ToLongDateString().Contains(txtKeyword.Text));
                        break;
                    case "Reference" :
                        _rentalAgreements = _rentalAgreementBl.GetActive(rent => rent.Reference.Contains(txtKeyword.Text));
                        break;
                    case "Sales" :
                        _rentalAgreements = _rentalAgreementBl.GetActive(rent => rent.CreatedBy.Name.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (_rentalAgreements != null)
            {
                foreach (var rentalAgreement in _rentalAgreements)
                {
                    dgvRentalAgreement.Rows.Add(rentalAgreement.Id, rentalAgreement.Customer.Name, rentalAgreement.AgreementDate, rentalAgreement.Reference, rentalAgreement.CreatedBy.Name);
                }
            }
            else
            {
                dgvRentalAgreement.Rows.Clear();
            }

            SelectedRentalAgreement = dgvRentalAgreement.CurrentRow != null ? _rentalAgreementBl.Get(rent => rent.Id == dgvRentalAgreement.CurrentRow.Cells["Id"].Value.ToString()).First() : null;

            SetDetails();
        }

        private void SetDetails()
        {
            dgvRentalAgreementDetail.Rows.Clear();

            if (SelectedRentalAgreement != null)
            {
                foreach (var rentalAgreementDetail in SelectedRentalAgreement.Details)
                {
                    dgvRentalAgreementDetail.Rows.Add(rentalAgreementDetail.Category.Id, rentalAgreementDetail.Category.Category, rentalAgreementDetail.Subcategory.Id, rentalAgreementDetail.Subcategory.Subcategory);
                }
            }
        }

        private void dgvRentalAgreement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void dgvRentalAgreement_SelectionChanged(object sender, EventArgs e)
        {
            SelectedRentalAgreement = dgvRentalAgreement.CurrentRow != null ? _rentalAgreementBl.Get(rent => rent.Id == dgvRentalAgreement.CurrentRow.Cells["Id"].Value.ToString()).First() : null;

            SetDetails();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}