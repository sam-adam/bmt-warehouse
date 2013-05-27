namespace Warehouse.Test
{
    using Autofac;
    using NUnit.Framework;
    using System.Transactions;
    using Warehouse.Business;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Data.Model;
    using Warehouse.Presentation;

    [TestFixture]
    public class RentalWithdrawalTest
    {
        private readonly Bootstrap _bootstrap;
        private readonly IContainer _container;

        public RentalWithdrawalTest()
        {
            _bootstrap = new Bootstrap();
            _container = _bootstrap.Configure();
        }

        [Test]
        public void GetRentalItems()
        {
            var facade = _container.Resolve<RentalWithdrawalFacade>();

            //Assert.IsNotEmpty(facade.GetRentalItems("CUS011"));
        }
    }
}
