using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using Warehouse.Presentation;

namespace Warehouse.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            var bootstrap = new Bootstrap();
            var container = bootstrap.Configure();

            Application.CurrentCulture = new CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.Run();
        }
    }
}