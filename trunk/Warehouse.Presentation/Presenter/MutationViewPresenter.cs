namespace Warehouse.Presentation.Presenter
{
    using System.Collections.Generic;
    using System.Linq;
    using Warehouse.Application;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Model;
    using Warehouse.Data.Model;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;

    public class MutationViewPresenter : BasePresenter
    {
        private readonly ICustomerBl _customerBl;
        private readonly IRentalProductBl _rentalProductBl;
        private readonly IRentalReceiptBl _rentalReceiptBl;
        private readonly IRentalWithdrawalBl _rentalWithdrawalBl;
        private IMutationViewForm _form;

        public MutationViewPresenter(EntityManager entityManager, ICustomerBl customerBl, IRentalProductBl rentalProductBl, IRentalReceiptBl rentalReceiptBl, IRentalWithdrawalBl rentalWithdrawalBl) : base(entityManager)
        {
            _customerBl = customerBl;
            _rentalProductBl = rentalProductBl;
            _rentalReceiptBl = rentalReceiptBl;
            _rentalWithdrawalBl = rentalWithdrawalBl;
        }

        public void SetForm(IMutationViewForm form)
        {
            _form = form;
        }

        public void GetCustomer(string id)
        {
            var customers = _customerBl.Get(id);

            var customer = customers != null ? customers.First() : null;

            _form.Customer = customer;

            if (customer != null)
            {
                GetCustomerProduct(customer);    
            }
        }

        public void GetCustomerProduct(Customer customer)
        {
            var rentalProducts = _rentalProductBl.Get(prod => prod.Customer == customer);

            if (rentalProducts != null)
            {
                _form.RentalProducts = rentalProducts;

                GetRentalProductMutationIn(rentalProducts.First().Id);
                GetRentalProductMutationOut(rentalProducts.First().Id);
            }
        }

        public void GetRentalProductMutationIn(string productId)
        {
            var rentalReceipts = _rentalReceiptBl.Get(rcpt => rcpt.Details.Any(dtl => dtl.RentalProduct.Id == productId));
            var mutationsIn = new List<MutationIn>();

            if (rentalReceipts != null)
            {
                foreach (var rentalReceipt in rentalReceipts)
                {
                    foreach (var detail in rentalReceipt.Details.Where(dtl => dtl.RentalProduct.Id == productId))
                    {
                        mutationsIn.Add(new MutationIn()
                            {
                                RentalProduct = detail.RentalProduct,
                                RentalReceipt = rentalReceipt,
                                Quantity = detail.Quantity
                            });
                    }
                }
            }

            _form.MutationsIn = mutationsIn;
        }

        public void GetRentalProductMutationOut(string productId)
        {
            var rentalWithdrawals = _rentalWithdrawalBl.Get(with => with.Details.Any(dtl => dtl.RentalProduct.Id == productId));
            var mutationsOut = new List<MutationOut>();

            if (rentalWithdrawals != null)
            {
                foreach (var rentalWithdrawal in rentalWithdrawals)
                {
                    foreach (var detail in rentalWithdrawal.Details.Where(dtl => dtl.RentalProduct.Id == productId))
                    {
                        mutationsOut.Add(new MutationOut()
                        {
                            RentalProduct = detail.RentalProduct,
                            RentalWithdrawal = rentalWithdrawal,
                            Quantity = detail.Quantity
                        });
                    }
                }
            }
            
            _form.MutationsOut = mutationsOut;
        }
    }
}