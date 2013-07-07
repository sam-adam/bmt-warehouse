namespace Warehouse.Presentation.Common
{
    using System.Windows.Forms;
    using Warehouse.Application;

    public enum ViewMode { Create, Edit, View }

    public partial class BaseForm : Form
    {
        public FormManager FormManager { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }


        public void CleanForm(object sender = null)
        {
            if (FormManager == null) FormManager = new FormManager();

            FormManager.ResetForm(this, sender);
        }
    }
}
