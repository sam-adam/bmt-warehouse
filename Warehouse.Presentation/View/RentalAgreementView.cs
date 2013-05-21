namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Warehouse.Business;
    using Warehouse.Data.Model;

    public partial class RentalAgreementView : Form
    {
        private readonly RentalAgreementBl _rentalAgreementBl;

        private List<RentalAgreement> _rentalAgreements;
        private List<RentalAgreementDetail> _rentalAgreementDetails;

        public RentalAgreement SelectedRentalAgreement { get; private set; }

        public RentalAgreementView(RentalAgreementBl rentalAgreementBl)
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

            RefreshRentalAgreementList();
        }

        private void RefreshRentalAgreementList()
        {
            dgvRentalAgreement.Rows.Clear();
            dgvRentalAgreementDetail.Rows.Clear();

            if (txtKeyword.Text == string.Empty)
            {
                _rentalAgreements = null;
            }
        }
    }
}
