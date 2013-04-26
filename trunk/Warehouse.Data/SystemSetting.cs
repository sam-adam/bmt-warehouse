namespace Warehouse.Data
{
    using Warehouse.Data.Contract;

    public class SystemSetting : ISystemSetting
    {
        public string ConnectionString
        {
            get { return Properties.Settings.Default.DevelopmentConnectionString; }
        }
    }
}
