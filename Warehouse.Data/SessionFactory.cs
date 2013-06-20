namespace Warehouse.Data
{
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using MySql.Data.MySqlClient;
    using NHibernate;
    using System;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Mapping;

    public class SessionFactory
    {
        private static ISessionFactory _sessionFactory;
        private static ISystemSetting _systemSetting;
        private static ISession _session;

        public SessionFactory()
        {
            _systemSetting = new SystemSetting();

            try
            {
                InitializeSessionFactory();
            }
            catch (Exception ex)
            {
                if (ex.InnerException is MySqlException)
                {
                    throw new Exception("Database is not ready, contact system admin");
                }
            }
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
            if (_session == null || !_session.IsOpen)
            {
                _session = _sessionFactory.OpenSession();
            }

            return _session;
        }
    }
}
