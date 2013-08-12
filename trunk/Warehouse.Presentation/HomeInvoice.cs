using Warehouse.Presentation.Common;

namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Autofac;
    using Warehouse.Presentation.View;

    public partial class HomeInvoice : Form
    {
        private readonly IContainer _container;
        private Form _frm;

        public HomeInvoice(IContainer container)
        {
            _container = container;

            InitializeComponent();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<RentalAgreementFrm>();
            
            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<RentalAgreementView>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<InvoiceWithdrawalFrm>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<InvoiceWithdrawalView>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void createNewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<InvoiceMonthlyFrm>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void vIewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<InvoiceMonthlyView>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }
    }
}
