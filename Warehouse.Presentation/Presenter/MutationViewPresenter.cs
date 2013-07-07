namespace Warehouse.Presentation.Presenter
{
    using System;
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

        public void GetMutation()
        {
            var customers = _customerBl.Get(_form.CustomerIdInput);
            var customer = customers != null ? customers.First() : null;

            _form.Customer = customer;

            if (customer != null)
            {
                var rentalProducts = _rentalProductBl.Get(prod => prod.Customer == customer);

                if (rentalProducts != null)
                {
                    _form.RentalProducts = rentalProducts;

                    _form.MutationsIn = GetRentalProductMutationIn(rentalProducts.First().Id, _form.MutationFrom, _form.MutationTo);
                    _form.MutationsOut = GetRentalProductMutationOut(rentalProducts.First().Id, _form.MutationFrom, _form.MutationTo);
                }
            }
        }

        public IList<MutationIn> GetRentalProductMutationIn(string productId, DateTime? from = null, DateTime? to = null)
        {
            var mutationsIn = new List<MutationIn>();
            var rentalReceipts = _rentalReceiptBl.Get(rcpt => 
                rcpt.Details.Any(dtl => dtl.RentalProduct.Id == productId));

            if (rentalReceipts != null)
            {
                if (from != null) rentalReceipts = rentalReceipts.Where(rcpt => rcpt.ReceiptDate >= from).ToList();
                if (to != null) rentalReceipts = rentalReceipts.Where(rcpt => rcpt.ReceiptDate <= to).ToList();

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

            return mutationsIn;
        }

        public IList<MutationOut> GetRentalProductMutationOut(string productId, DateTime? from = null, DateTime? to = null)
        {
            var mutationsOut = new List<MutationOut>();
            var rentalWithdrawals = _rentalWithdrawalBl.Get(with => 
                with.Details.Any(dtl => dtl.RentalProduct.Id == productId));

            if (rentalWithdrawals != null)
            {
                if (from != null) rentalWithdrawals = rentalWithdrawals.Where(with => with.WithdrawalDate >= from).ToList();
                if (to != null) rentalWithdrawals = rentalWithdrawals.Where(with => with.WithdrawalDate <= to).ToList();

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
            
            return mutationsOut;
        }

        public double GetProductBalance(string productId)
        {
            var mutationsIn = GetRentalProductMutationIn(productId, to: _form.MutationFrom);
            var mutationsOut = GetRentalProductMutationOut(productId, to: _form.MutationFrom);

            var beginingBalance = mutationsIn.Sum(mutationIn => mutationIn.Quantity);

            return mutationsOut.Aggregate(beginingBalance, (current, mutationOut) => current - mutationOut.Quantity);
        }

        public void GetRentalProductMutations(string productId)
        {
            _form.MutationsIn = GetRentalProductMutationIn(productId);
            _form.MutationsOut = GetRentalProductMutationOut(productId);
        }
    }
}