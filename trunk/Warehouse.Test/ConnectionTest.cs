using Autofac;
using NUnit.Framework;
using Warehouse.Data.Model;
using Warehouse.Presentation;
using Warehouse.Data.Contract;
using System.Collections.Generic;
using System.Linq;

namespace Warehouse.Test
{
    [TestFixture]
    public class ConnectionTest
    {
        [Test]
        public void AutofacTest()
        {
            var bootstrap = new Bootstrap();
            var container = bootstrap.Configure();

            var userRepository = container.Resolve<IUserRepository>();

            List<User> userList = userRepository.GetAllAsEnumerable().ToList();
        }
    }
}
