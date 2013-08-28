using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.Business.Contract;
using Warehouse.Data.Model;
using Warehouse.Presentation.Print;

namespace Warehouse.Presentation.View
{
    public partial class RentalReceiptView : Form
    {
        private readonly IRentalReceiptBl _rentalReceiptBl;
        private readonly PrintFrm _printFrm;
        private readonly RentalReceiptRpt _report;
        private RentalReceipt _rentalReceipt;
        public Form Caller { get; set; }
        public RentalReceipt RentalReceipt { get; private set; }

        #region Constructors
        public RentalReceiptView(IRentalReceiptBl rentalReceiptBl, PrintFrm printFrm, RentalReceiptRpt report)
        {
            _rentalReceiptBl = rentalReceiptBl;
            _printFrm = printFrm;
            _report = report;

            InitializeComponent();
        }

        #endregion

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            RentalReceipt = _rentalReceipt;

            if (keyData == Keys.Enter && Caller != null)
            {
                if (RentalReceipt == null)
                {
                    MessageBox.Show(@"No selected rental receipt");
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
        private void RentalReceiptView_Load(object sender, EventArgs e)
        {
            if (Caller == null) tssHelpEnter.Visible = false;

            txtKeyword.Clear();
            cboCriteria.SelectedIndex = 0;

            RentalReceipt = null;
            _rentalReceipt = null;

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
            dgvRentalReceipt.Rows.Clear();

            IList<RentalReceipt> rentalReceipts = null;

            if (txtKeyword.Text == string.Empty)
            {
                rentalReceipts = _rentalReceiptBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Customer":
                        rentalReceipts = _rentalReceiptBl.Get(rent => rent.RentalAgreement.Customer.Name.Contains(txtKeyword.Text));
                        break;
                    case "RentalAgreement Id":
                        rentalReceipts = _rentalReceiptBl.Get(rent => rent.Id.Contains(txtKeyword.Text));
                        break;
                    case "Agreement Date":
                        rentalReceipts = _rentalReceiptBl.Get(rent => rent.ReceiptDate.ToString(CultureInfo.InvariantCulture).Contains(txtKeyword.Text));
                        break;
                    case "Reference":
                        rentalReceipts = _rentalReceiptBl.Get(rent => rent.Reference.Contains(txtKeyword.Text));
                        break;
                    case "Sales":
                        rentalReceipts = _rentalReceiptBl.Get(rent => rent.CreatedBy.Name.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (rentalReceipts != null)
            {
                foreach (var rentalReceipt in rentalReceipts)
                {
                    dgvRentalReceipt.Rows.Add(
                        rentalReceipt.Id,
                        rentalReceipt.RentalAgreement.Customer.Id,
                        rentalReceipt.RentalAgreement.Customer.Name,
                        rentalReceipt.RentalAgreement.Id,
                        rentalReceipt.ReceiptDate.ToShortDateString(),
                        rentalReceipt.Sender,
                        rentalReceipt.Reference,
                        rentalReceipt.CreatedBy.Id,
                        rentalReceipt.CreatedBy.Name
                        );
                }
            }

            SetDetails();
        }

        private void SetDetails()
        {
            dgvRentalReceiptDetail.Rows.Clear();

            if (dgvRentalReceipt.CurrentRow != null)
            {
                var rentalReceipts = _rentalReceiptBl.Get(dgvRentalReceipt.CurrentRow.Cells["Id"].Value.ToString());

                if (rentalReceipts != null)
                {
                    var rentalReceipt = rentalReceipts.First();

                    foreach (var detail in rentalReceipt.Details)
                    {
                        dgvRentalReceiptDetail.Rows.Add(
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvRentalReceipt.CurrentRow != null)
            {
                Print(_rentalReceiptBl.Get(dgvRentalReceipt.CurrentRow.Cells["Id"].Value.ToString()).First(), _report.ResourceName);
            }
        }

        private void Print(RentalReceipt rentalReceipt, string reportFileName)
        {
            _printFrm.RecordSelectionFormula = "{tbl_trrentalreceipt1.id_rentalreceipt}='" + rentalReceipt.Id + "'";
            _printFrm.ReportFilename = reportFileName;

            _printFrm.ShowDialog();
        }
    }
}
