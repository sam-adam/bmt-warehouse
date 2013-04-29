namespace Warehouse.Presentation
{
    using Autofac;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.XtraBars;

    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IContainer _container;

        public Home(IContainer container)
        {
            _container = container;

            InitializeComponent();
        }
    }
}