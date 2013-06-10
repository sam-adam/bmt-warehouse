namespace Warehouse.Test
{
    using System.Linq;
    using Autofac;
    using NUnit.Framework;
    using Warehouse.Business;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation;

    [TestFixture]
    public class ProductCategoryTest
    {
        [Test]
        public void GetProductCategory()
        {
            var bootstrap = new Bootstrap();
            var container = bootstrap.Configure();

            var rentalAgreementBl = container.Resolve<RentalAgreementBl>();

        }
    }
}
