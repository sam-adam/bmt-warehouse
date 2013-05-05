using System.Linq;
using System.Transactions;
using System.Collections.Generic;
using Warehouse.Data;
using Warehouse.Data.Contract;
using FluentNHibernate.Testing;

namespace Warehouse.Test
{
    using Autofac;
    using NUnit.Framework;
    using Warehouse.Business;
    using Warehouse.Data.Model;
    using Warehouse.Infrastructure;

    [TestFixture]
    public class RentalAgreementTest
    {
        private TransactionScope _scope;
        private readonly Bootstrap _bootstrap;
        private IContainer _container;

        public RentalAgreementTest()
        {
            _bootstrap = new Bootstrap();
            _container = _bootstrap.Configure();   
        }

        [SetUp]
        public void SetUp()
        {
            _scope = new TransactionScope();
        }

        [TearDown]
        public void TearDown()
        {
            _scope.Dispose();
        }

        [Test]
        public IList<RentalAgreement> Select()
        {
            var rentalAgreementBl = _container.Resolve<IRentalAgreementRepository>();
            var rentalAgreements = rentalAgreementBl.GetAll().ToList();

            return rentalAgreements;
        }

        [Test]
        public void CanMapRentalAgreement()
        {
            new PersistenceSpecification<RentalAgreement>(new SessionFactory().OpenSession())
                .CheckProperty(rent => rent.Id, "newid")
                .CheckProperty(rent => rent.CreatedDate, "newdate")
                .CheckProperty(rent => rent.CreatedBy, new Employee())
                .CheckProperty(rent => rent.Customer, new Customer())
                .VerifyTheMappings();
        }

        [Test]
        public void AddNew()
        {
            var rentalAgreementBl = _container.Resolve<RentalAgreementBl>();

            var newRental = new RentalAgreement
                {
                    Id = "newid",
                    AgreementDate = "newagreementdate",
                    CreatedBy = new Employee(),
                    CreatedDate = "newcreateddate",
                    Customer = new Customer(),
                    Reference = "newreference",
                    Status = "newstatus"
                };

            newRental.AddRentalAgreementDetail(new RentalAgreementDetail()
                {
                    Category = new ProductCategory(),
                    Price = 123,
                    RentalAgreement = newRental,
                    Subcategory = new ProductSubcategory()
                });

            //rentalAgreementBl.AddNewRentalAgreement(newRental);

            Assert.IsNotNull(Select());
        }
    }
}
