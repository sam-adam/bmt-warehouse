namespace Warehouse.Business
{
    using Warehouse.Data.Model;
    using Warehouse.Data.Contract;
    using System.Linq;

    public class RentalReceiptBl
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRentalAgreementRepository _rentalAgreementRepository;
        private readonly IRentalReceiptRepository _rentalReceiptRepository;

        public RentalReceiptBl(ICustomerRepository customerRepository, IRentalAgreementRepository rentalAgreementRepository, IRentalReceiptRepository rentalReceiptRepository)
        {
            _customerRepository = customerRepository;
            _rentalAgreementRepository = rentalAgreementRepository;
            _rentalReceiptRepository = rentalReceiptRepository;
        }

        public RentalAgreement GetRentalAgreement(string rentalAgreementId)
        {
            var rentalAgreement = _rentalAgreementRepository.Get(x => x.Id == rentalAgreementId).ToList();

            return rentalAgreement.Any() ? rentalAgreement.First() : null;
        }

        public bool IsActiveRentalAgreement(RentalAgreement rentalAgreement)
        {
            return rentalAgreement.Status.ToUpperInvariant() == "ACTIVE";
        }

        public RentalAgreement GetCustomerRentalAgreement(string customerId)
        {
            var customerList = _customerRepository.Get(cust => cust.Id == customerId).ToList();

            if (customerList.Any())
            {
                var customer = customerList.First();
                var rentalAgreement = customer.GetActiveRental();

                if (rentalAgreement != null)
                {
                    return rentalAgreement;
                }
            }

            return null;
        }
    }
}
