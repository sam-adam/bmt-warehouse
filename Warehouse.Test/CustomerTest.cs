namespace Warehouse.Test
{
    using Autofac;
    using NUnit.Framework;
    using Warehouse.Business;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Infrastructure;
    using System.Linq;

    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void GetCustomers()
        {
            var bootstrap = new Bootstrap();
            var container = bootstrap.Configure();

            var rentalAgreementBl = container.Resolve<RentalAgreementBl>();
        }
    }
}
