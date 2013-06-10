using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using FluentNHibernate.Testing;
using NUnit.Framework;
using Warehouse.Data;
using Warehouse.Data.Contract;
using Warehouse.Data.Model;
using Warehouse.Presentation;

namespace Warehouse.Test
{
    [TestFixture]
    public class InvoiceWithdrawalTest
    {
        private readonly Bootstrap _bootstrap;
        private readonly IContainer _container;

        public InvoiceWithdrawalTest()
        {
            _bootstrap = new Bootstrap();
            _container = _bootstrap.Configure();
        }

        [Test]
        public IList<InvoiceWithdrawal> Select()
        {
            var rentalAgreementBl = _container.Resolve<IInvoiceWithdrawalRepository>();
            var rentalAgreements = rentalAgreementBl.GetAll().ToList();

            return rentalAgreements;
        }

        [Test]
        public void CanMapRentalAgreement()
        {
            new PersistenceSpecification<InvoiceWithdrawal>(new SessionFactory().OpenSession())
                .CheckProperty(rent => rent.Id, "newid")
                .CheckProperty(rent => rent.CreatedDate, new DateTime())
                .CheckProperty(rent => rent.CreatedBy, new Employee())
                .CheckProperty(rent => rent.RentalAgreement, new RentalAgreement())
                .CheckProperty(rent => rent.RentalWithdrawal, new RentalWithdrawal())
                .VerifyTheMappings();
        }
    }
}
