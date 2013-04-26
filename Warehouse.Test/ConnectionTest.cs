using System;
using MySql.Data.MySqlClient;

namespace Warehouse.Test
{
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
    }
}
