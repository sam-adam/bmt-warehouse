namespace Warehouse.Presentation.Contract
{
    using System.Windows.Forms;

    public interface IForm
    {
        void CleanForm(object sender, Control.ControlCollection controls);
    }
}
