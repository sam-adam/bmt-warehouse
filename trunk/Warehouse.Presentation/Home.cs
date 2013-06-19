namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Autofac;
    using Warehouse.Presentation.View;

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

        private void button5_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<InvoiceWithdrawalFrm>();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<RentalAgreementView>();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var form = _container.Resolve<RentalWithdrawalView>())
            {
                form.ShowDialog();   
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var form = _container.Resolve<RentalReceiptView>())
            {
                form.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (var form = _container.Resolve<InvoiceWithdrawalView>())
            {
                form.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var form = _container.Resolve<InvoiceMonthlyView>())
            {
                form.ShowDialog();
            }
        }
    }
}
