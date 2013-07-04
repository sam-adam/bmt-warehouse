namespace Warehouse.Presentation
{
    using System.Windows.Forms;
    using Warehouse.Presentation.Presenter;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;

    public partial class LoginForm : BaseForm, ILoginForm, IConnectionSettingForm
    {
        private readonly LoginPresenter _presenter;
        private readonly ConnectionSettingPresenter _connectionSettingPresenter;
        private bool _loggedIn;

        public LoginForm(LoginPresenter presenter, ConnectionSettingPresenter connectionSettingPresenter)
        {
            _presenter = presenter;
            _connectionSettingPresenter = connectionSettingPresenter;
            
            InitializeComponent();

            _presenter.SetForm(this);
            _connectionSettingPresenter.SetForm(this);
        }

        #region ILoginForm Members

        public string UsernameInput
        {
            get { return txtUsername.Text.Trim(); }
        }

        public string PasswordInput
        {
            get { return txtPassword.Text; }
        }

        public bool LoggedIn
        {
            get
            {
                return _loggedIn;
            }

            set
            {
                _loggedIn = value;

                if (_loggedIn)
                {
                    Dispose();
                }
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        #endregion

        #region IConnectionSettingForm Members
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
            get { return txtConnectionPassword.Text; }
            set { txtConnectionPassword.Text = value; }
        }
        #endregion

        private void btnTest_Click(object sender, System.EventArgs e)
        {
            _connectionSettingPresenter.TestConnection();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _connectionSettingPresenter.SaveConnection();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            _presenter.DoLogin();
        }
    }
}
