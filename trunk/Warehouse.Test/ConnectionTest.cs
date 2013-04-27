using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Warehouse.Infrastructure;

namespace Warehouse.Test
{
    using Autofac;
    using NUnit.Framework;
    using NHibernate;
    using Warehouse.Data;
    using Warehouse.Data.Contract;

    [TestFixture]
    public class ConnectionTest
    {
        [Test]
        public void CanConnect()
        {
            ISystemSetting systemSetting = new SystemSetting();
            ISession session = new SessionFactory(systemSetting).OpenSession();
        }

        [Test]
        public void AutofactTest()
        {
            var bootstrap = new Bootstrap();
            var container = bootstrap.Configure();

            using (var session = container.Resolve<SessionFactory>().OpenSession())
            {
                using (session)
                {
                    
                }
            }
        }
    }
}
