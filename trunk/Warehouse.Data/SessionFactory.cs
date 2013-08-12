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
        private static ISession _session;

        private readonly ISystemSetting _systemSetting;

        public SessionFactory(ISystemSetting systemSetting)
        {
            _systemSetting = systemSetting;

            InitializeSessionFactory();
        }

        private void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
            .Database(MySQLConfiguration
                .Standard
                .ConnectionString(_systemSetting.ConnectionString))
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>())
            .ExposeConfiguration(c => c.Properties.Add("hbm2ddl.keywords", "none"))
            .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            InitializeSessionFactory();

            _session = _sessionFactory.OpenSession();

            return _session;
        }
    }
}
