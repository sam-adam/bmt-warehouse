namespace Warehouse.Presentation
{
    using CrystalDecisions.CrystalReports.Engine;
    using System;
    using System.Windows.Forms;

    public partial class PrintFrm : Form
    {
        private readonly ReportDocument _reportDocument;

        public string ReportFilename { get; set; }
        public string RecordSelectionFormula { get; set; }

        public PrintFrm(ReportDocument reportDocument)
        {
            _reportDocument = reportDocument;

            InitializeComponent();
        }

        private void PrintFrm_Load(object sender, EventArgs e)
        {
            var reportDir = Application.StartupPath;

            if (reportDir.EndsWith("\\bin\\Debug"))
            {
                reportDir = reportDir.Replace("\\bin\\Debug", "");
            }
            else if (reportDir.EndsWith("\\bin\\x86\\Debug"))
            {
                reportDir = reportDir.Replace("\\bin\\x86\\Debug", "");
            }

            var reportPath = reportDir + "\\Print\\" + ReportFilename;

            if (string.IsNullOrEmpty(ReportFilename)) { throw new NullReferenceException("Report Filename"); }

            _reportDocument.Load(reportPath);

            if (!string.IsNullOrEmpty(RecordSelectionFormula))
            {
                _reportDocument.RecordSelectionFormula = RecordSelectionFormula;
            }

            _reportDocument.Refresh();
            
            crystalReportViewer.PrintReport();
            crystalReportViewer.ReportSource = _reportDocument;
            crystalReportViewer.Refresh();
        }
    }
}