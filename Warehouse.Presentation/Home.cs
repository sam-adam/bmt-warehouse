using System;
using System.Windows.Forms;
using Autofac;
using Autofac.Core;

namespace Warehouse.Presentation
{
    public partial class Home : Form
    {
        private readonly IContainer _container;

        public Home(IContainer container)
        {
            _container = container;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<RentalAgreementFrm>();
            form.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<RentalReceiptFrm>();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<RentalWithdrawalFrm>();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<InvoiceMonthlyFrm>();
            form.ShowDialog();
        }
    }
}
