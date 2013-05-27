namespace Warehouse.Business.Facade
{
    using System.Linq;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public class RentalReceiptFacade
    {
        private readonly ICustomerBl _customerBl;
        private readonly IRentalAgreementBl _rentalAgreementBl;
        private readonly IRentalReceiptBl _rentalReceiptBl;
        private readonly RentalAgreementDetailFacade _rentalAgreementDetailFacade;

        public RentalReceiptFacade(ICustomerBl customerBl, IRentalAgreementBl rentalAgreementBl, IRentalReceiptBl rentalReceiptBl, RentalAgreementDetailFacade rentalAgreementDetailFacade)
        {
            _customerBl = customerBl;
            _rentalAgreementBl = rentalAgreementBl;
            _rentalReceiptBl = rentalReceiptBl;
            _rentalAgreementDetailFacade = rentalAgreementDetailFacade;
        }

        public RentalAgreement GetRentalAgreement(string id)
        {
            var rentalAgreement = _rentalAgreementBl.Get(id);

            return rentalAgreement != null ? rentalAgreement.First() : null;
        }

        public RentalAgreement GetCustomerRentalAgreement(string customerId)
        {
            var customer = _customerBl.Get(customerId);

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

        public string Save(RentalReceipt rentalReceipt)
        {
            return _rentalReceiptBl.Save(rentalReceipt);
        }

        public string GetNewId()
        {
            return _rentalReceiptBl.GenerateNewId();
        }
    }
}