namespace Warehouse.Presentation.View
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public partial class InvoiceMonthlyView : Form
    {
        private readonly IInvoiceMonthlyBl _invoiceMonthlyBl;
        private InvoiceMonthly _invoiceMonthly;
        public Form Caller { get; set; }
        public InvoiceMonthly InvoiceMonthly { get; private set; }

        #region Constructors
        public InvoiceMonthlyView(IInvoiceMonthlyBl invoiceMonthlyBl)
        {
            _invoiceMonthlyBl = invoiceMonthlyBl;

            InitializeComponent();
        }

        #endregion

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            InvoiceMonthly = _invoiceMonthly;

            if (keyData == Keys.Enter && Caller != null)
            {
                if (InvoiceMonthly == null)
                {
                    MessageBox.Show(@"No selected rental invoice monthly");
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
        private void InvoiceMonthlyView_Load(object sender, EventArgs e)
        {
            if (Caller == null) tssHelpEnter.Visible = false;

            txtKeyword.Clear();
            cboCriteria.SelectedIndex = 0;

            InvoiceMonthly = null;
            _invoiceMonthly = null;

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

        private void dgvInvoiceMonthly_SelectionChanged(object sender, EventArgs e)
        {
            SetDetails();
        }
        #endregion

        #region Functions
        private void RefreshList()
        {
            dgvInvoiceMonthly.Rows.Clear();

            IList<InvoiceMonthly> invoiceMonthlies = null;

            if (txtKeyword.Text == string.Empty)
            {
                invoiceMonthlies = _invoiceMonthlyBl.GetAll();
            }
            else
            {
                switch (cboCriteria.SelectedItem.ToString())
                {
                    case "Customer":
                        invoiceMonthlies = _invoiceMonthlyBl.Get(inv => inv.RentalAgreement.Customer.Name.Contains(txtKeyword.Text));
                        break;
                    case "InvoiceMonthly Id":
                        invoiceMonthlies = _invoiceMonthlyBl.Get(inv => inv.Id.Contains(txtKeyword.Text));
                        break;
                    case "RentalAgreement Id":
                        invoiceMonthlies = _invoiceMonthlyBl.Get(inv => inv.RentalAgreement.Id.Contains(txtKeyword.Text));
                        break;
                    case "Invoice Date":
                        invoiceMonthlies = _invoiceMonthlyBl.Get(inv => inv.InvoiceDate.ToString(CultureInfo.InvariantCulture).Contains(txtKeyword.Text));
                        break;
                    case "Sales":
                        invoiceMonthlies = _invoiceMonthlyBl.Get(inv => inv.CreatedBy.Name.Contains(txtKeyword.Text));
                        break;
                }
            }

            if (invoiceMonthlies != null)
            {
                foreach (var invoiceMonthly in invoiceMonthlies)
                {
                    var monthly = invoiceMonthly;

                    dgvInvoiceMonthly.Rows.Add(
                        invoiceMonthly.Id,
                        invoiceMonthly.RentalAgreement.Customer.Id,
                        invoiceMonthly.RentalAgreement.Customer.Name,
                        invoiceMonthly.RentalAgreement.Id,
                        invoiceMonthly.InvoiceDate.ToShortDateString(),
                        invoiceMonthly.CreatedBy.Id,
                        invoiceMonthly.CreatedBy.Name,
                        invoiceMonthly.Discount.ToString("N2"),
                        invoiceMonthly.DiscountRemark,
                        (invoiceMonthly.Details.Where(dtl => monthly != null && dtl.InvoiceMonthly == monthly).Sum(dtl => dtl.Quantity * dtl.Price) - monthly.Discount).ToString("N2")
                        );
                }
            }

            SetDetails();
        }

        private void SetDetails()
        {
            dgvInvoiceMonthlyDetail.Rows.Clear();

            if (dgvInvoiceMonthly.CurrentRow != null)
            {
                var invoiceMonthlies = _invoiceMonthlyBl.Get(dgvInvoiceMonthly.CurrentRow.Cells["Id"].Value.ToString());

                if (invoiceMonthlies != null)
                {
                    var invoiceMonthly = invoiceMonthlies.First();

                    foreach (var detail in invoiceMonthly.Details)
                    {
                        dgvInvoiceMonthlyDetail.Rows.Add(
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

        private void dgvInvoiceMonthly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetDetails();
        }
    }
}
