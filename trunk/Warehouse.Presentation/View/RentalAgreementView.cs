namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Application;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Delegates;
    
    public partial class RentalAgreementView : Form
    {
        public delegate void RentalAgreementSelectHandler(object sender, RentalAgreementSelectEventArgs e);
        public event RentalAgreementSelectHandler RentalAgreementSelected;
        
        private readonly IRentalAgreementBl _rentalAgreementBl;
        private readonly RentalAgreementFrm _rentalAgreementFrm;
        private RentalAgreement _rentalAgreement;
        
        #region Constructors
        public RentalAgreementView(IRentalAgreementBl rentalAgreementBl, RentalAgreementFrm rentalAgreementFrm)
        {
            _rentalAgreementBl = rentalAgreementBl;
            _rentalAgreementFrm = rentalAgreementFrm;

            InitializeComponent();
        }
        #endregion

        public RentalAgreement RentalAgreement { get; private set; }

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            RentalAgreement = _rentalAgreement;

            if (keyData == Keys.Enter)
            {
                if (RentalAgreement == null)
                {
                    MessageBox.Show(@"No selected rental agreement");
                }
                else
                {
                    SetRentalAgreement();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Events
        private void RentalAgreementView_Load(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            cboCriteria.SelectedIndex = 0;

            RentalAgreement = null;
            _rentalAgreement = null;

            RefreshList();
        }

        private void dgvRentalAgreement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dgvRentalAgreement_SelectionChanged(object sender, EventArgs e)
        {
            SetDetails();
        }

        private void cboCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
        #endregion

        #region Functions
        private void SetRentalAgreement()
        {
            var args = new RentalAgreementSelectEventArgs(RentalAgreement);

            RentalAgreementSelected(this, args);

            _rentalAgreementFrm.Show();

            

            Close();
        }

        private void RefreshList()
        {
            dgvRentalAgreement.Rows.Clear();

            IList<RentalAgreement> rentalAgreements = null;

            if (txtKeyword.Text == string.Empty)
            {
                rentalAgreements = _rentalAgreementBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Customer":
                        rentalAgreements = _rentalAgreementBl.Get(rent => rent.Customer.Name.Contains(txtKeyword.Text));
                        break;
                    case "RentalAgreement Id":
                        rentalAgreements = _rentalAgreementBl.Get(rent => rent.Id.Contains(txtKeyword.Text));
                        break;
                    case "Agreement Date":
                        rentalAgreements = _rentalAgreementBl.Get(rent => rent.AgreementDate.ToString(CultureInfo.InvariantCulture).Contains(txtKeyword.Text));
                        break;
                    case "Reference":
                        rentalAgreements = _rentalAgreementBl.Get(rent => rent.Reference.Contains(txtKeyword.Text));
                        break;
                    case "Sales":
                        rentalAgreements = _rentalAgreementBl.Get(rent => rent.CreatedBy.Name.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (rentalAgreements != null)
            {
                foreach (var rentalAgreement in rentalAgreements)
                {
                    dgvRentalAgreement.Rows.Add(
                        rentalAgreement.Id,
                        rentalAgreement.Customer.Id,
                        rentalAgreement.Customer.Name,
                        rentalAgreement.AgreementDate.ToShortDateString(),
                        rentalAgreement.CutOffDate,
                        rentalAgreement.Reference,
                        rentalAgreement.CreatedBy.Id,
                        rentalAgreement.CreatedBy.Name,
                        rentalAgreement.Status
                        );
                }
            }

            SetDetails();
        }

        private void SetDetails()
        {
            dgvRentalAgreementDetail.Rows.Clear();

            if (dgvRentalAgreement.CurrentRow != null)
            {
                var rentalAgreements = _rentalAgreementBl.Get(dgvRentalAgreement.CurrentRow.Cells["Id"].Value.ToString());

                if (rentalAgreements != null)
                {
                    _rentalAgreement = rentalAgreements.First();

                    foreach (var detail in _rentalAgreement.Details)
                    {
                        dgvRentalAgreementDetail.Rows.Add(
                            detail.Category.Id,
                            detail.Category.Category,
                            detail.Subcategory.Id,
                            detail.Subcategory.Subcategory,
                            detail.Price.ToString("N2")
                            );
                    }
                }
            }
        }
        #endregion
    }
}