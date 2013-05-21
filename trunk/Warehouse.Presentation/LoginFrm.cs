namespace Warehouse.Presentation
{
    using System;
    using System.Windows.Forms;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public partial class LoginFrm : Form
    {
        private readonly ILoginBl _loginBl;

        public bool LoggedIn { get; private set; }

        public LoginFrm(ILoginBl loginBl)
        {
            _loginBl = loginBl;

            LoggedIn = false;

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == ""  || txtPassword.Text == "")
            {
                MessageBox.Show(@"Username and password must be filled");
            }
            else
            {
                LoggedIn = _loginBl.DoLogin(new User {Username = txtUsername.Text, Password = txtPassword.Text});
                
                if (!LoggedIn)
                {
                    MessageBox.Show(@"Username or password is wrong");
                }
                else
                {
                    MessageBox.Show(@"Login success");

                    Dispose();
                }
            }
        }
    }
}
