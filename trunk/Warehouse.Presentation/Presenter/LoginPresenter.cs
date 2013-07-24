namespace Warehouse.Presentation.Presenter
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Warehouse.Application;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Helper.Logging;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;

    public class LoginPresenter : BasePresenter
    {
        private readonly ILoginBl _loginBl;
        private ILoginForm _form;

        public LoginPresenter(ILoginBl loginBl, EntityManager entityManager) : base(entityManager)
        {
            _loginBl = loginBl;
        }

        public void SetForm(ILoginForm form)
        {
            _form = form;
        }

        public void DoLogin()
        {
            var user = new User {Username = _form.UsernameInput, Password = _form.PasswordInput};

            var errors = EntityManager.Validate(user);

            if (errors.Count > 0)
            {
                MessageBox.Show(errors.First());
            }
            else
            {
                try
                {
                    var isLoggedIn = _loginBl.DoLogin(user);

                    if (!isLoggedIn)
                    {
                        MessageBox.Show(@"User not found");
                    }
                    else
                    {
                        _form.LoggedIn = true;

                        MessageBox.Show(@"Logged in");
                    }
                }
                catch (Exception ex)
                {
                    var exceptionLogger = new ExceptionLogger(new TextFileWriter());
                    exceptionLogger.Log(ex);

                    MessageBox.Show(@"Connection failed");

                    throw;
                }
            }
        }
    }
}