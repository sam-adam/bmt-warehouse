namespace Warehouse.Data
{
    using FluentNHibernate.Cfg.Db;
    using Warehouse.Data.Contract;

    public class MySqlFluentConfiguration : IFluentConfiguration<MySQLConfiguration, MySQLConnectionStringBuilder>
    {
        private readonly ISystemSetting _systemSetting;

        private static MySQLConfiguration Configuration
        {
            get
            {
                return MySQLConfiguration
                    .Standard
                    .ConnectionString("")
                    .Driver<NHibernate.Driver.MySqlDataDriver>();
            }
        }

        public MySqlFluentConfiguration(ISystemSetting systemSetting)
        {
            _systemSetting = systemSetting;
        }

        PersistenceConfiguration<MySQLConfiguration, MySQLConnectionStringBuilder> IFluentConfiguration<MySQLConfiguration, MySQLConnectionStringBuilder>.Configuration
        {
            get { return Configuration; }
        }
    }
}