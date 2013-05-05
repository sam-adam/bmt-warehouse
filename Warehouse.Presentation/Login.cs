namespace Warehouse.Presentation
{
    using Autofac;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Warehouse.Business;
    using Warehouse.Data.Model;

    public partial class Login : Form
    {
        private readonly IContainer _container;
        private readonly LoginBl _loginBl;

        private bool _loggedIn;

        public bool LoggedIn { get { return _loggedIn; } }

        public Login(IContainer container)
        {
            _container = container;
            _loginBl = _container.Resolve<LoginBl>();

            _loggedIn = false;

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
                _loggedIn = _loginBl.DoLogin(new User {Username = txtUsername.Text, Password = txtPassword.Text});
                
                if (!_loggedIn)
                {
                    MessageBox.Show(@"Username or password is wrong");
                }
                else
                {
                    MessageBox.Show(@"Login success");

                    Dispose(true);
                }
            }
        }
    }
}
