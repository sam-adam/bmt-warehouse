namespace Warehouse.Data
{
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Mapping;

    public class SessionFactory
    {
        private static ISessionFactory _sessionFactory;
        private static ISystemSetting _systemSetting;

        public SessionFactory()
        {
            _systemSetting = new SystemSetting();

            InitializeSessionFactory();
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MySQLConfiguration
                    .Standard
                    .ConnectionString(_systemSetting.ConnectionString)
                    .Driver<NHibernate.Driver.MySqlDataDriver>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>())
                .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
