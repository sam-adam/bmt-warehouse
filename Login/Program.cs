namespace Warehouse.Presentation
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Warehouse.Infrastructure;

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
                var login = new Login(container);

                login.ShowDialog();

                if (login.LoggedIn)
                {
                    Application.Run(new Home(container));   
                }
            }
        }
    }
}