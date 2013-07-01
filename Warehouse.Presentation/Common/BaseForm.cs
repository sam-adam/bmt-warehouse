namespace Warehouse.Presentation.Common
{
    using System.Windows.Forms;
    using Warehouse.Application;

    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public FormManager FormManager { get; set; }

        public void CleanForm()
        {
            FormManager.ResetForm(this);
        }

        public enum ViewMode { Create, Edit, View }
    }
}
