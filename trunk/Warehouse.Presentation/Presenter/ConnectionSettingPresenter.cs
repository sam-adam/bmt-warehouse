namespace Warehouse.Presentation.Presenter
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Windows.Forms;
    using Warehouse.Application;
    using Warehouse.Data.Contract;
    using Warehouse.Helper;
    using Warehouse.Helper.Logging;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;

    public class ConnectionSettingPresenter : BasePresenter
    {
        private readonly ApplicationManager _applicationManager;
        private IConnectionSettingForm _form;

        public bool CanConnect { get; set; }
        
        public ConnectionSettingPresenter(EntityManager entityManager, ApplicationManager applicationManager) : base(entityManager)
        {
            _applicationManager = applicationManager;
        }

        public void SetForm(IConnectionSettingForm form)
        {
            _form = form;

            _form.Server = _applicationManager.ApplicationConnection.Server;
            _form.Database = _applicationManager.ApplicationConnection.Database;
            _form.UserId = _applicationManager.ApplicationConnection.UserId;
            _form.Password = _applicationManager.ApplicationConnection.Password;
        }

        public void TestConnection()
        {
            var systemSetting = new TestSystemSetting
            {
                Server = _form.Server,
                Database = _form.Database,
                UserId = _form.UserId,
                Password = _form.Password,
                AllowZeroDatetime = _applicationManager.ApplicationConnection.AllowZeroDatetime,
                ConvertZeroDatetime = _applicationManager.ApplicationConnection.ConvertZeroDatetime
            };

            using (var connection = new MySqlConnection(systemSetting.ConnectionString))
            {
                try
                {
                    connection.Open();

                    MessageBox.Show(@"Connection success");

                    CanConnect = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Connection failed");

                    CanConnect = false;

                    var exceptionLogger = new ExceptionLogger(new TextFileWriter());
                    exceptionLogger.Log(ex);
                }
            }
        }

        public void SaveConnection()
        {
            if (MessageBox.Show(@"Save connection setting?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TestConnection();

                if (!CanConnect)
                {
                    MessageBox.Show(@"Cannot save invalid connection setting");
                }
                else
                {
                    _applicationManager.SetConnectionProperties(_form.Server, _form.Database, _form.UserId, _form.Password);

                    MessageBox.Show(@"Connection setting saved");
                }
            }
        }
    }

    internal class TestSystemSetting : ISystemSetting
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string AllowZeroDatetime { get; set; }
        public string ConvertZeroDatetime { get; set; }

        public string ConnectionString
        {
            get
            {
                return string.Format("Server={0};Database={1};User Id={2};Password={3};Allow Zero Datetime={4};Convert Zero Datetime={5}",
                    Server,
                    Database,
                    UserId,
                    Password,
                    AllowZeroDatetime,
                    ConvertZeroDatetime);
            }
        }
    }
}
