using System.Windows.Forms;

namespace Warehouse.Presentation
{
    using System;
    using DevExpress.XtraEditors;
    using Warehouse.Business;
    using Warehouse.Data.Model;

    public partial class Login : XtraForm
    {
        private readonly UserBl _userBl;

        public Login()
        {
            _userBl = new UserBl();

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username have to be filled");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password have to be filled");
            }
            else
            {
                var userList = _userBl.Get(new User()
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text
                    });

                MessageBox.Show(userList != null ? "Login success" : "Username or password is incorrect");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}