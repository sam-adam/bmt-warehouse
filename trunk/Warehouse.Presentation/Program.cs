namespace Warehouse.Presentation
{
    using Autofac;
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    static class Program
    {
        [MTAThread]
        static void Main()
        {
            var bootstrap = new Bootstrap();
            
            Application.CurrentCulture = new CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            using (var container = bootstrap.Configure())
            {
                var login = container.Resolve<LoginFrm>();

                login.ShowDialog();

                if (login.LoggedIn)
                {
                    Application.Run(container.Resolve<RentalWithdrawalFrm>());
                }
            }
        }
    }
}