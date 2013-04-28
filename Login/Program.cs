namespace Warehouse.Presentation
{
    using Autofac;
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Warehouse.Business;
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
                Application.Run(new Login(container));   
            }
        }
    }
}