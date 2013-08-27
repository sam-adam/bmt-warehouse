namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public partial class InvoiceWithdrawalView : Form
    {
        private readonly IInvoiceWithdrawalBl _invoiceWithdrawalBl;
        private InvoiceWithdrawal _invoiceWithdrawal;
        public Form Caller { get; set; }
        public InvoiceWithdrawal InvoiceWithdrawal { get; private set; }

        #region Constructors
        public InvoiceWithdrawalView(IInvoiceWithdrawalBl invoiceWithdrawalBl)
        {
            _invoiceWithdrawalBl = invoiceWithdrawalBl;

            InitializeComponent();
        }

        #endregion

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            InvoiceWithdrawal = _invoiceWithdrawal;

            if (keyData == Keys.Enter)
            {
                if (InvoiceWithdrawal == null)
                {
                    MessageBox.Show(@"No selected rental invoice withdrawal");
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
        private void InvoiceWithdrawalView_Load(object sender, EventArgs e)
        {
            if (Caller == null) tssHelpEnter.Visible = false;

            txtKeyword.Clear();
            cboCriteria.SelectedIndex = 0;

            InvoiceWithdrawal = null;
            _invoiceWithdrawal = null;

            RefreshList();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void cboCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dgvInvoiceWithdrawal_SelectionChanged(object sender, EventArgs e)
        {
            SetDetails();
        }
        #endregion

        #region Functions
        private void RefreshList()
        {
            dgvInvoiceWithdrawal.Rows.Clear();

            IList<InvoiceWithdrawal> invoiceWithdrawals = null;

            if (txtKeyword.Text == string.Empty)
            {
                invoiceWithdrawals = _invoiceWithdrawalBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Customer":
                        invoiceWithdrawals = _invoiceWithdrawalBl.Get(inv => inv.RentalAgreement.Customer.Name.Contains(txtKeyword.Text));
                        break;
                    case "InvoiceWithdrawal Id":
                        invoiceWithdrawals = _invoiceWithdrawalBl.Get(inv => inv.Id.Contains(txtKeyword.Text));
                        break;
                    case "RentalWithdrawal Id":
                        invoiceWithdrawals = _invoiceWithdrawalBl.Get(inv => inv.RentalWithdrawal.Id.Contains(txtKeyword.Text));
                        break;
                    case "RentalAgreement Id":
                        invoiceWithdrawals = _invoiceWithdrawalBl.Get(inv => inv.RentalAgreement.Id.Contains(txtKeyword.Text));
                        break;
                    case "Invoice Date":
                        invoiceWithdrawals = _invoiceWithdrawalBl.Get(inv => inv.InvoiceDate.ToString(CultureInfo.InvariantCulture).Contains(txtKeyword.Text));
                        break;
                    case "Sales":
                        invoiceWithdrawals = _invoiceWithdrawalBl.Get(inv => inv.CreatedBy.Name.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (invoiceWithdrawals != null)
            {
                foreach (var invoiceWithdrawal in invoiceWithdrawals)
                {
                    var withdrawal = invoiceWithdrawal;

                    dgvInvoiceWithdrawal.Rows.Add(
                        invoiceWithdrawal.Id,
                        invoiceWithdrawal.RentalAgreement.Customer.Id,
                        invoiceWithdrawal.RentalAgreement.Customer.Name,
                        invoiceWithdrawal.RentalWithdrawal.Id,
                        invoiceWithdrawal.RentalAgreement.Id,
                        invoiceWithdrawal.InvoiceDate.ToShortDateString(),
                        invoiceWithdrawal.CreatedBy.Id,
                        invoiceWithdrawal.CreatedBy.Name,
                        invoiceWithdrawal.Details.Where(dtl => withdrawal != null && dtl.InvoiceWithdrawal == withdrawal).Sum(dtl => dtl.Quantity * dtl.Price).ToString("N2")
                        );
                }

                dgvInvoiceWithdrawal.Sort(dgvInvoiceWithdrawal.Columns["InvoiceDate"], ListSortDirection.Descending);
            }

            SetDetails();
        }

        private void SetDetails()
        {
            dgvInvoiceWithdrawalDetail.Rows.Clear();

            if (dgvInvoiceWithdrawal.CurrentRow != null)
            {
                var invoiceWithdrawals = _invoiceWithdrawalBl.Get(dgvInvoiceWithdrawal.CurrentRow.Cells["Id"].Value.ToString());

                if (invoiceWithdrawals != null)
                {
                    _invoiceWithdrawal = invoiceWithdrawals.First();

                    foreach (var detail in _invoiceWithdrawal.Details)
                    {
                        dgvInvoiceWithdrawalDetail.Rows.Add(
                            detail.RentalProduct.ProductCategory.Id,
                            detail.RentalProduct.ProductCategory.Category,
                            detail.RentalProduct.ProductSubcategory.Id,
                            detail.RentalProduct.ProductSubcategory.Subcategory,
                            detail.RentalProduct.Brand,
                            detail.RentalProduct.Description,
                            detail.Quantity,
                            detail.Price.ToString("N2"),
                            (detail.Quantity * detail.Price).ToString("N2")
                            );
                    }
                }
            }
        }
        #endregion

        private void dgvInvoiceWithdrawal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetDetails();
        }
    }
}