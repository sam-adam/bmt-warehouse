namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Autofac;
    using Warehouse.Presentation.View;

    public partial class HomeWarehouse : Form
    {
        private readonly IContainer _container;
        private Form _frm;

        public HomeWarehouse(IContainer container)
        {
            _container = container;

            InitializeComponent();
        }

        private void createNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<RentalWithdrawalFrm>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<RentalWithdrawalView>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void createNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<RentalReceiptFrm>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _frm = _container.Resolve<RentalReceiptView>();

            _frm.MdiParent = this;
            _frm.Show();
            _frm.BringToFront();
            _frm.WindowState = FormWindowState.Maximized;
        }
    }
}
