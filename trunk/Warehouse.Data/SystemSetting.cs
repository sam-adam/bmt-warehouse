namespace Warehouse.Data
{
    using Warehouse.Application;
    using Warehouse.Data.Contract;

    public class SystemSetting : ISystemSetting
    {
        private readonly ApplicationManager _applicationManager;

        public SystemSetting(ApplicationManager applicationManager)
        {
            _applicationManager = applicationManager;
        }

        public string ConnectionString
        {
            get
            {
                return string.Format("Server={0};Database={1};User Id={2};Password={3};Allow Zero Datetime={4};Convert Zero Datetime={5}", 
                    _applicationManager.ApplicationConnection.Server,
                    _applicationManager.ApplicationConnection.Database,
                    _applicationManager.ApplicationConnection.UserId,
                    _applicationManager.ApplicationConnection.Password,
                    _applicationManager.ApplicationConnection.AllowZeroDatetime,
                    _applicationManager.ApplicationConnection.ConvertZeroDatetime);
            }
        }
    }
}
