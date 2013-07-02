namespace Warehouse.Presentation
{
    using System.Windows.Forms;
    using Warehouse.Presentation.Presenter;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;

    public partial class LoginForm : BaseForm, ILoginForm
    {
        private readonly LoginPresenter _presenter;
        private bool _loggedIn;

        public LoginForm(LoginPresenter presenter)
        {
            _presenter = presenter;
            _presenter.SetForm(this);

            InitializeComponent();
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

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            CleanForm();
            _presenter.DoLogin();
        }
    }
}
