namespace Warehouse.Presentation.Presenter
{
    using Warehouse.Application;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;

    public class RentalAgreementPresenter : BasePresenter
    {
        private readonly IRentalAgreementBl _rentalAgreementBl;
        private IRentalAgreementForm _form;

        public RentalAgreementPresenter(EntityManager entityManager, IRentalAgreementBl rentalAgreementBl) : base(entityManager)
        {
            _rentalAgreementBl = rentalAgreementBl;
        }

        public void SetForm(IRentalAgreementForm form)
        {
            _form = form;
        }

        public void GetCustomerById()
        {
            var customerId = _form.CustomerIdInput;

            if (!string.IsNullOrEmpty(customerId) || customerId.Length != 6)
            {
                var customer = _rentalAgreementBl.GetCustomer(customerId);

                if (customer != null)
                {
                    
                }
            }
        }
    }
}
