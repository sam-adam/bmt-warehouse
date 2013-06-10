namespace Warehouse.Presentation
{
    using CrystalDecisions.CrystalReports.Engine;
    using System;
    using System.Windows.Forms;

    public partial class PrintFrm : Form
    {
        private readonly ReportDocument _reportDocument;

        public object DataSource { get; set; }
        public string ReportFilename { get; set; }

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

            var reportPath = reportDir + "\\Print\\" + ReportFilename;

            if (string.IsNullOrEmpty(ReportFilename)) { throw new NullReferenceException("Report Filename"); }
            if (DataSource.Equals(null)) { throw new NullReferenceException("Data Source"); }

            _reportDocument.Load(reportPath);
            _reportDocument.SetDataSource(DataSource);

            crystalReportViewer.ReportSource = _reportDocument;
            crystalReportViewer.RefreshReport();
        }
    }
}