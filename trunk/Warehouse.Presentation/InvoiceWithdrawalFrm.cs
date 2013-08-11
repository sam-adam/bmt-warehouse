namespace Warehouse.Presentation
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Print;
    using Warehouse.Presentation.View;

    public partial class InvoiceWithdrawalFrm : Form
    {
        private readonly PrintFrm _printFrm;
        private readonly InvoiceWithdrawalRpt _report;
        private readonly IInvoiceWithdrawalBl _invoiceWithdrawalBl;
        private readonly InvoiceWithdrawalView _view;

        private InvoiceWithdrawal _invoice;

        #region Constructors
        public InvoiceWithdrawalFrm(PrintFrm printFrm, InvoiceWithdrawalRpt report, IInvoiceWithdrawalBl invoiceWithdrawalBl, InvoiceWithdrawalView view)
        {
            _printFrm = printFrm;
            _report = report;
            _invoiceWithdrawalBl = invoiceWithdrawalBl;
            _view = view;

            InitializeComponent();
        }
        #endregion

        #region Events
        private void txtWithdrawalId_TextChanged(object sender, EventArgs e)
        {
            ClearForm(txtWithdrawalId);

            if (txtWithdrawalId.Text.Length == 15)
            {
                try
                {
                    _invoice = _invoiceWithdrawalBl.GetSingle(txtWithdrawalId.Text);

                    if (_invoice != null)
                    {
                        SetData(_invoice);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    ClearForm(txtWithdrawalId);

                    txtWithdrawalId.Focus();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_invoice != null)
            {
                Print(_invoice, _report.ResourceName);

                Dispose();
            }
            else
            {
                MessageBox.Show(@"No invoice selected");
            }
        }

        private void btnViewInvoiceWithdrawal_Click(object sender, EventArgs e)
        {
            LoadWithdrawalView();
        }
        #endregion

        #region Functions
        private void LoadWithdrawalView()
        {
            _view.ShowDialog();

            _invoice = _view.InvoiceWithdrawal;

            if (_invoice != null)
            {
                txtCustomerId.Text = _invoice.Id;
            }
        }

        private void ClearForm(object sender = null, Control.ControlCollection controlCollection = null)
        {
            _invoice = null;

            if (controlCollection == null) controlCollection = Controls;

            foreach (Control control in controlCollection)
            {
                if (control.GetType() == typeof(TextBox) && !ReferenceEquals(control, sender))
                {
                    var txtControl = control as TextBox;

                    if (txtControl != null) txtControl.Clear();
                }

                if (control.Controls.Count > 0) ClearForm(sender, control.Controls);
            }

            dgvInvoiceWithdrawalDetail.Rows.Clear();
        }

        private void SetData(InvoiceWithdrawal invoiceWithdrawal)
        {
            txtAgreementId.Text = invoiceWithdrawal.RentalAgreement.Id;
            txtAgreementSales.Text = invoiceWithdrawal.RentalAgreement.CreatedBy.Id;
            txtAgreementSalesName.Text = invoiceWithdrawal.RentalAgreement.CreatedBy.Name;
            txtAgreementReference.Text = invoiceWithdrawal.RentalAgreement.Reference;
            txtAgreementCutOffDate.Text = invoiceWithdrawal.RentalAgreement.CutOffDate.ToString(CultureInfo.InvariantCulture);
            txtCustomerId.Text = invoiceWithdrawal.RentalAgreement.Customer.Id;
            txtCustomerName.Text = invoiceWithdrawal.RentalAgreement.Customer.Name;
            txtCustomerTitle.Text = invoiceWithdrawal.RentalAgreement.Customer.Title;
            txtCustomerPhone.Text = invoiceWithdrawal.RentalAgreement.Customer.Phone;
            txtCustomerEmail.Text = invoiceWithdrawal.RentalAgreement.Customer.Email;
            txtCustomerAddress.Text = invoiceWithdrawal.RentalAgreement.Customer.Address1 + Environment.NewLine +
                                        invoiceWithdrawal.RentalAgreement.Customer.Address2 + Environment.NewLine +
                                        invoiceWithdrawal.RentalAgreement.Customer.Address3;

            dgvInvoiceWithdrawalDetail.Rows.Clear();

            foreach (var detail in invoiceWithdrawal.Details)
            {
                dgvInvoiceWithdrawalDetail.Rows.Add(detail.RentalProduct.Id, detail.RentalProduct.ProductCategory.Id,
                                                    detail.RentalProduct.ProductCategory.Category,
                                                    detail.RentalProduct.ProductSubcategory.Id,
                                                    detail.RentalProduct.ProductSubcategory.Subcategory,
                                                    detail.RentalProduct.Brand, detail.RentalProduct.Description,
                                                    detail.Quantity, detail.Price, (detail.Quantity*detail.Price));
            }

            var total = CountTotal();

            txtTotal.Text = total.ToString("N2");
        }

        private Double CountTotal()
        {
            var total = dgvInvoiceWithdrawalDetail.Rows.Cast<DataGridViewRow>().Sum(row => Double.Parse(row.Cells["Subtotal"].Value.ToString()));

            return total;
        }

        private void Print(InvoiceWithdrawal invoiceWithdrawal, string reportFileName)
        {
            _printFrm.RecordSelectionFormula = "{tbl_trinvoicewithdrawal1.id_invoicewithdrawal}='" + invoiceWithdrawal.Id + "'";
            _printFrm.ReportFilename = reportFileName;

            _printFrm.ShowDialog();
        }
        #endregion

        #region Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                LoadWithdrawalView();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
