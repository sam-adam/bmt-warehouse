namespace Warehouse.Presentation.View
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Data.Model;

    public partial class RentalAgreementDetailView : Form
    {
        public RentalAgreement RentalAgreement { get; set; }
        public RentalAgreementDetail RentalAgreementDetail { get; set; }

        public RentalAgreementDetailView()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (RentalAgreementDetail == null)
                {
                    MessageBox.Show(@"No selected rental agreement detail");
                }
                else
                {
                    Close();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RentalAgreementDetailView_Load(object sender, EventArgs e)
        {
            dgvRentalAgreementDetail.Rows.Clear();

            if (RentalAgreement == null)
            {
                MessageBox.Show(@"No rental agreement selected");

                Close();
            }
            else
            {
                var tempRentalDetails = RentalAgreement.Details;

                foreach (var rentalAgreementDetail in tempRentalDetails)
                {
                    dgvRentalAgreementDetail.Rows.Add(rentalAgreementDetail.Category.Id,
                                                      rentalAgreementDetail.Category.Category,
                                                      rentalAgreementDetail.Subcategory.Id,
                                                      rentalAgreementDetail.Subcategory.Subcategory);
                }

                SetSelectedDetail();
            }
        }

        private void SetSelectedDetail()
        {
            var tempSelectedRow = dgvRentalAgreementDetail.CurrentRow;

            if (tempSelectedRow == null)
            {
                RentalAgreementDetail = null;
            }
            else
            {
                var tempRentalDetails = RentalAgreement.Details;

                RentalAgreementDetail =
                    tempRentalDetails.First(
                        dtl => dtl.Category.Id == tempSelectedRow.Cells["CategoryId"].Value.ToString() 
                               && dtl.Subcategory.Id == tempSelectedRow.Cells["SubcategoryId"].Value.ToString()
                    );
            }
        }

        private void dgvRentalAgreementDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void dgvRentalAgreementDetail_SelectionChanged(object sender, EventArgs e)
        {
            SetSelectedDetail();
        }
    }
}