namespace Warehouse.Presentation
{
    using Autofac;
    using System;
    using System.Windows.Forms;
    using Warehouse.Business;
    using Warehouse.Data.Model;

    public partial class Login : Form
    {
        private readonly IContainer _container;
        private readonly UserBl _userBl;

        public Login(IContainer container)
        {
            _container = container;
            _userBl = _container.Resolve<UserBl>();

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == ""  || txtPassword.Text == "")
            {
                MessageBox.Show(@"Username and password must be filled");
            }
            else
            {
                var users = _userBl.Get(new User {Username = txtUsername.Text, Password = txtPassword.Text});
                
                if (users == null)
                {
                    MessageBox.Show(@"Username or password is wrong");
                }
                else
                {
                    MessageBox.Show(@"Login success");
                }
            }
        }
    }
}
