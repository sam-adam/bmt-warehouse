namespace Warehouse.Presentation.Controls
{
    using System.Windows.Forms;
    using System.Windows.Forms.Design;

    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip |
                                       ToolStripItemDesignerAvailability.ContextMenuStrip |
                                       ToolStripItemDesignerAvailability.StatusStrip)]
    public class ButtonStripItem  : ToolStripControlHost
    {
        private Button _button;

        public ButtonStripItem() : base(new Button())
        {
            _button = Control as Button;
        }

        public ButtonStripItem(Control c, string name) : base(c, name)
        {
        }
    }
}
