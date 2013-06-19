namespace Warehouse.Business.Facade
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class RentalReceiptFacade
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRentalAgreementRepository _rentalAgreementRepository;
        private readonly IRentalProductBl _rentalProductBl;
        private readonly RentalAgreementDetailFacade _rentalAgreementDetailFacade;

        public RentalReceiptFacade(ICustomerRepository customerRepository, IRentalAgreementRepository rentalAgreementRepository, RentalAgreementDetailFacade rentalAgreementDetailFacade, IRentalProductBl rentalProductBl)
        {
            _customerRepository = customerRepository;
            _rentalAgreementRepository = rentalAgreementRepository;
            _rentalAgreementDetailFacade = rentalAgreementDetailFacade;
            _rentalProductBl = rentalProductBl;
        }

        public RentalAgreement GetRentalAgreement(string id)
        {
            var rentalAgreements = _rentalAgreementRepository.Get(rent => rent.Id == id);

            return rentalAgreements != null ? rentalAgreements.First() : null;
        }

        public RentalAgreement GetCustomerRentalAgreement(string id)
        {
            var customer = _customerRepository.Get(cust => cust.Id == id);

            return customer != null ? customer.First().GetActiveRental() : null;
        }

        public ProductCategory GetCategory(string id)
        {
            return _rentalAgreementDetailFacade.GetSingleCategory(id);
        }

        public ProductSubcategory GetSubcategory(string id)
        {
            return _rentalAgreementDetailFacade.GetSingleSubcategory(id);
        }

        public RentalProduct GetRentalProduct(Expression<Func<RentalProduct, bool>> func)
        {
            var rentalProducts = _rentalProductBl.Get(func);

            return rentalProducts == null ? null : rentalProducts.First();
        }

        public void UpdateRentalProductStock(RentalProduct rentalProduct)
        {
            _rentalProductBl.Update(rentalProduct);
        }

        public string SaveRentalProduct(RentalProduct rentalProduct)
        {
            return _rentalProductBl.Save(rentalProduct);
        }
    }
}