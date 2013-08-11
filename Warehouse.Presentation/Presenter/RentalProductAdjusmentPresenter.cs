using System.Windows.Forms;

namespace Warehouse.Presentation.Presenter
{
    using Warehouse.Application;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;
    using Warehouse.Business;
    using Warehouse.Data.Model;

    public class RentalProductAdjusmentPresenter : BasePresenter
    {
        private readonly RentalProductAdjustmentBl _rentalProductAdjustmentBl;
        private IRentalProductAdjustmentForm _form;

        public RentalProductAdjusmentPresenter(EntityManager entityManager, RentalProductAdjustmentBl rentalProductAdjustmentBl) : base(entityManager)
        {
            _rentalProductAdjustmentBl = rentalProductAdjustmentBl;
        }

        public void SetForm(IRentalProductAdjustmentForm rentalProductAdjustmentForm)
        {
            _form = rentalProductAdjustmentForm;
        }

        public void GetCustomer()
        {
            var customerId = _form.CustomerIdInput;

            if (customerId.Length == 6)
            {
                var customer = _rentalProductAdjustmentBl.GetCustomer(customerId);

                _form.Customer = customer;
                _form.Details = _rentalProductAdjustmentBl.GetCustomerRentalItems(customer);
            }
            else
            {
                _form.Customer = null;
            }
        }

        public void Save()
        {
            var rentalProductAdjusment = new RentalProductAdjustment()
                {
                    Id = _rentalProductAdjustmentBl.GenerateNewId()
                };

            foreach (var detail in _form.Details)
            {
                if (detail.PreviousStock == detail.AdjustedStock)
                {
                    _form.Details.Remove(detail);
                }
                else
                {
                    detail.RentalProductAdjusment = rentalProductAdjusment;   
                }
            }

            rentalProductAdjusment.Details = _form.Details;

            var message = _rentalProductAdjustmentBl.Save(rentalProductAdjusment);

            MessageBox.Show(message);
        }
    }
}
