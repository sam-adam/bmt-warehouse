namespace Warehouse.Application
{
    using System;
    using System.Windows.Forms;
    using Warehouse.Application.Common;

    public class FormManager : ObjectManager
    {
        public Form Form { get; private set; }

        public void ResetForm(Form form, object sender = null)
        {
            if (form == null)
            {
                throw new ArgumentNullException("form");
            }

            Form = form;

            CleanForm(sender);
        }

        private void CleanForm(object sender = null, Control.ControlCollection controls = null)
        {
            if (controls == null) controls = Form.Controls;

            foreach (Control control in controls)
            {
                if (ReferenceEquals(sender, control) || control == null) continue;

                var controlType = control.GetType();

                if (control.Controls.Count > 0 && controlType != typeof(DataGridView)) CleanForm(sender, control.Controls);

                if (controlType == typeof(TextBox))
                {
                    var txtControl = control as TextBox;
                    if (txtControl != null) txtControl.Clear();
                }
                else if (controlType == typeof(ComboBox))
                {
                    var cboControl = control as ComboBox;
                    if (cboControl != null) cboControl.SelectedIndex = -1;
                }
                else if (controlType == typeof(DataGridView))
                {
                    var dgvControl = control as DataGridView;
                    if (dgvControl != null) dgvControl.Rows.Clear();
                }
            }
        }
    }
}
