using Warehouse.Presentation.Common;

namespace Warehouse.Presentation
{
    using Autofac;
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            var bootstrap = new Bootstrap();
            
            Application.CurrentCulture = new CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var container = bootstrap.Configure())
            {
                //var test = container.Resolve<Test>();
                //test.ShowDialog();
                var login = container.Resolve<LoginForm>();

                login.ShowDialog();

                if (login.LoggedIn)
                {
                    var home = new Home(container);
                    Application.Run(home);
                }
            }
        }
    }
}