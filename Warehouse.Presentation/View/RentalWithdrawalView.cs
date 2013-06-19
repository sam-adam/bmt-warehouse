namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public partial class RentalWithdrawalView : Form
    {
        private readonly IRentalWithdrawalBl _rentalWithdrawalBl;
        private RentalWithdrawal _rentalWithdrawal;
        public Form Caller { get; set; }
        public RentalWithdrawal RentalWithdrawal { get; private set; }

        #region Constructors
        public RentalWithdrawalView(IRentalWithdrawalBl rentalWithdrawalBl)
        {
            _rentalWithdrawalBl = rentalWithdrawalBl;

            InitializeComponent();
        }
        #endregion

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            RentalWithdrawal = _rentalWithdrawal;

            if (keyData == Keys.Enter && Caller != null)
            {
                if (RentalWithdrawal == null)
                {
                    MessageBox.Show(@"No selected rental withdrawal");
                }
                else
                {
                    Close();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Events
        private void RentalWithdrawalView_Load(object sender, EventArgs e)
        {
            if (Caller == null) tssHelpEnter.Visible = false;

            txtKeyword.Clear();
            cboCriteria.SelectedIndex = 0;

            RentalWithdrawal = null;
            _rentalWithdrawal = null;

            RefreshList();
        }

        private void dgvRentalWithdrawal_SelectionChanged(object sender, EventArgs e)
        {
            SetDetails();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void cboCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
        #endregion

        #region Functions
        private void RefreshList()
        {
            dgvRentalWithdrawal.Rows.Clear();

            IList<RentalWithdrawal> rentalWithdrawals = null;

            if (txtKeyword.Text == string.Empty)
            {
                rentalWithdrawals = _rentalWithdrawalBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Customer":
                        rentalWithdrawals = _rentalWithdrawalBl.Get(rent => rent.Customer.Name.Contains(txtKeyword.Text));
                        break;
                    case "RentalAgreement Id":
                        rentalWithdrawals = _rentalWithdrawalBl.Get(rent => rent.Id.Contains(txtKeyword.Text));
                        break;
                    case "Agreement Date":
                        rentalWithdrawals = _rentalWithdrawalBl.Get(rent => rent.WithdrawalDate.ToString(CultureInfo.InvariantCulture).Contains(txtKeyword.Text));
                        break;
                    case "Reference":
                        rentalWithdrawals = _rentalWithdrawalBl.Get(rent => rent.Reference.Contains(txtKeyword.Text));
                        break;
                    case "Sales":
                        rentalWithdrawals = _rentalWithdrawalBl.Get(rent => rent.CreatedBy.Name.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (rentalWithdrawals != null)
            {
                foreach (var rentalWithdrawal in rentalWithdrawals)
                {
                    dgvRentalWithdrawal.Rows.Add(
                        rentalWithdrawal.Id,
                        rentalWithdrawal.Customer.Id,
                        rentalWithdrawal.Customer.Name,
                        rentalWithdrawal.WithdrawalDate.ToShortDateString(),
                        rentalWithdrawal.Reference,
                        rentalWithdrawal.CreatedBy.Id,
                        rentalWithdrawal.CreatedBy.Name
                        );
                }
            }

            SetDetails();
        }

        private void SetDetails()
        {
            dgvRentalWithdrawalDetail.Rows.Clear();

            if (dgvRentalWithdrawal.CurrentRow != null)
            {
                var rentalWithdrawals = _rentalWithdrawalBl.Get(dgvRentalWithdrawal.CurrentRow.Cells["Id"].Value.ToString());

                if (rentalWithdrawals != null)
                {
                    var rentalWithdrawal = rentalWithdrawals.First();

                    foreach (var detail in rentalWithdrawal.Details)
                    {
                        dgvRentalWithdrawalDetail.Rows.Add(
                            detail.RentalProduct.ProductCategory.Id,
                            detail.RentalProduct.ProductCategory.Category,
                            detail.RentalProduct.ProductSubcategory.Id,
                            detail.RentalProduct.ProductSubcategory.Subcategory,
                            detail.RentalProduct.Brand,
                            detail.RentalProduct.Description,
                            detail.Quantity
                            );
                    }
                }
            }
        }
        #endregion
    }
}
