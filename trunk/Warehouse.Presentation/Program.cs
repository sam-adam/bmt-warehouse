namespace Warehouse.Presentation
{
    using Autofac;
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Warehouse.Helper.Logging;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                var bootstrap = new Bootstrap();

                Application.CurrentCulture = new CultureInfo("en-US");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (var container = bootstrap.Configure())
                {
                    var login = container.Resolve<LoginForm>();

                    login.ShowDialog();

                    if (login.LoggedIn)
                    {
                        var home = new HomeWarehouse(container);
                        Application.Run(home);
                    }
                }
            }
            catch (Exception ex)
            {
                var exceptionLogger = LoggerFactory.GetExceptionLogger("ExceptionLogger");

                exceptionLogger.Log(ex);

                MessageBox.Show(ex.Message);
            }
        }
    }
}