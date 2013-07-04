namespace Warehouse.Presentation
{
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;
    using Warehouse.Presentation.Presenter;

    public partial class ConnectionSettingForm : BaseForm, IConnectionSettingForm
    {
        private readonly ConnectionSettingPresenter _presenter;

        public ConnectionSettingForm(ConnectionSettingPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            _presenter.SetForm(this);
        }

        public string Server
        {
            get { return txtServer.Text; }
            set { txtServer.Text = value; }
        }

        public string Database
        {
            get { return txtDatabase.Text; }
            set { txtDatabase.Text = value; }
        }

        public string UserId
        {
            get { return txtUserId.Text; }
            set { txtUserId.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void btnTest_Click(object sender, System.EventArgs e)
        {
            _presenter.TestConnection();
        }
    }
}
