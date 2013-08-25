namespace Warehouse.Business.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;

    public class RentalWithdrawalFacade
    {
        private readonly ICustomerBl _customerBl;
        private readonly IRentalReceiptBl _rentalReceiptBl;
        private readonly IProductCategoryBl _categoryBl;
        private readonly IProductSubcategoryBl _subcategoryBl;
        private readonly IRentalProductBl _rentalProductBl;
        private readonly IInvoiceWithdrawalBl _invoiceWithdrawalBl;

        public RentalWithdrawalFacade(ICustomerBl customerBl, IRentalReceiptBl rentalReceiptBl, IProductCategoryBl categoryBl, IProductSubcategoryBl subcategoryBl, IRentalProductBl rentalProductBl, IInvoiceWithdrawalBl invoiceWithdrawalBl)
        {
            _customerBl = customerBl;
            _rentalReceiptBl = rentalReceiptBl;
            _categoryBl = categoryBl;
            _subcategoryBl = subcategoryBl;
            _rentalProductBl = rentalProductBl;
            _invoiceWithdrawalBl = invoiceWithdrawalBl;
        }

        public IList<RentalReceiptDetail> GetRentalReceiptDetail(string customerId)
        {
            var customer = GetCustomer(customerId);

            if (customer == null) return null;

            var customerRentals = _rentalReceiptBl.Get(rent => rent.RentalAgreement.Customer == customer
                                                               && rent.Status == "ACTIVE");

            if (customerRentals == null) return null;

            var receiptDetails = customerRentals.SelectMany(customerRental => customerRental.Details).ToList();

            return receiptDetails.Any() ? receiptDetails : null;
        } 

        public Customer GetCustomer(string id)
        {
            var customers = _customerBl.Get(id);

            return customers.Any() ? customers.First() : null;
        }

        public ProductCategory GetCategory(string id)
        {
            var category = _categoryBl.Get(id);

            return category.Any() ? category.First() : null;
        }

        public ProductSubcategory GetSubcategory(string id)
        {
            var subcategory = _subcategoryBl.Get(id);

            return subcategory.Any() ? subcategory.First() : null;
        }

        public IList<RentalReceipt> GetRentalReceipt(Expression<Func<RentalReceipt, bool>> predicate)
        {
            var rentalReceipts = _rentalReceiptBl.Get(predicate);

            return rentalReceipts.Any() ? rentalReceipts : null;
        }

        public IList<RentalProduct> GetCustomerRentalProducts(Customer customer)
        {
            return _rentalProductBl.Get(prod => prod.Customer == customer);
        }

        public string UpdateRentalProduct(RentalProduct rentalProduct)
        {
            return _rentalProductBl.Update(rentalProduct);
        }

        public string AddInvoiceWithdrawal(RentalWithdrawal rentalWithdrawal)
        {
            var activeRentalAgreement = _customerBl.Get(cust => cust.Id == rentalWithdrawal.Customer.Id).First().GetActiveRental();
            var invoiceWithdrawal = new InvoiceWithdrawal()
                {
                    Id = _invoiceWithdrawalBl.GenerateNewId(),
                    RentalWithdrawal = rentalWithdrawal,
                    RentalAgreement = activeRentalAgreement,
                    CreatedDate = rentalWithdrawal.CreatedDate,
                    InvoiceDate = rentalWithdrawal.WithdrawalDate,
                };

            foreach (var withdrawalDetail in rentalWithdrawal.Details)
            {
                var rentalProduct = withdrawalDetail.RentalProduct;
                var rentalProductPrice = activeRentalAgreement.Details.First(dtl => dtl.Category.Category == rentalProduct.ProductCategory.Category && dtl.Subcategory.Subcategory == rentalProduct.ProductSubcategory.Subcategory).Price;
                var invoiceWithdrawalDetail = new InvoiceWithdrawalDetail()
                    {
                        InvoiceWithdrawal = invoiceWithdrawal,
                        RentalProduct = rentalProduct,
                        Quantity = withdrawalDetail.Quantity,
                        Price = rentalProductPrice
                    };

                invoiceWithdrawal.AddDetail(invoiceWithdrawalDetail);
            }

            return _invoiceWithdrawalBl.Save(invoiceWithdrawal);
        }
    }
}
