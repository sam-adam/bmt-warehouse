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
        private RentalAgreement _rentalAgreement;
        public Form Caller { get; set; }
        public RentalAgreement RentalAgreement
        {
            get { return _rentalAgreement; }
            private set { _rentalAgreement = value; }
        }

        #region Constructors
        public RentalAgreementView(IRentalAgreementBl rentalAgreementBl)
        {
            _rentalAgreementBl = rentalAgreementBl;

            InitializeComponent();
        }

        #endregion

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Events
        private void RentalAgreementView_Load(object sender, EventArgs e)
        {
            RefreshList();
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

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Functions
        private void RefreshList()
        {
            dgvRentalAgreement.Rows.Clear();

            dgvRentalAgreement.DataSource = _rentalAgreements;
        }

        private void SetDetails()
        {
            
        }
        #endregion
    }
}