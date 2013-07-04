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
                    .ConnectionString(_systemSetting.ConnectionString)
                    .Driver<NHibernate.Driver.MySqlDataDriver>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>())
                .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                InitializeSessionFactory();    
            }

            if (_session == null || !_session.IsOpen)
            {
                _session = _sessionFactory.OpenSession();
            }

            return _session;
        }
    }
}
