namespace Warehouse.Business
{
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Data.Repository;
    using Warehouse.Business.Contract;
    using Warehouse.Helper;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;

    public class InvoiceMonthlyBl : IInvoiceMonthlyBl
    {
        private readonly Common _common;
        private readonly IInvoiceMonthlyRepository _repository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IRentalProductRepository _productRepository;
        private readonly IRentalReceiptRepository _receiptRepository;
        private readonly IRentalWithdrawalRepository _withdrawalRepository;
        private readonly RentalProductAdjustmentRepository _adjustmentRepository;

        public InvoiceMonthlyBl(
            Common common, 
            IInvoiceMonthlyRepository repository, 
            ICustomerRepository customerRepository, 
            IRentalProductRepository productRepository, 
            IRentalReceiptRepository receiptRepository, 
            IRentalWithdrawalRepository withdrawalRepository, 
            RentalProductAdjustmentRepository adjustmentRepository)
        {
            _common = common;
            _repository = repository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _receiptRepository = receiptRepository;
            _withdrawalRepository = withdrawalRepository;
            _adjustmentRepository = adjustmentRepository;
        }

        public string GenerateNewId()
        {
            var currentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var branch = _common.LoggedInUser.Employee.Branch;
            var lastInvoice = _repository.GetAll().OrderByDescending(inv => inv.InvoiceDate);
            var newInvoiceMonth = !lastInvoice.Any() ? DateTime.Now.Month : lastInvoice.First().InvoiceDate.NextMonth().Month;
            
            return string.Format("IM{0}/{1}{2}.{3}", branch, newInvoiceMonth, currentYear, "0001");
        }

        public string Save(InvoiceMonthly invoiceMonthly)
        {
            Validate(invoiceMonthly);

            var customer = invoiceMonthly.RentalAgreement.Customer;
            var lastInvoiceMonthly = GetLastInvoiceForCustomer(customer);
            var rentalCutOffDate = invoiceMonthly.RentalAgreement.CutOffDate;
            
            invoiceMonthly.Period = rentalCutOffDate > invoiceMonthly.InvoiceDate.Date.Day ? 
                DateTimeHelper.GetDateTime(rentalCutOffDate, invoiceMonthly.InvoiceDate.PreviousMonth().Month, DateTime.Now.Year) : 
                DateTimeHelper.GetDateTime(rentalCutOffDate, invoiceMonthly.InvoiceDate.Month, DateTime.Now.Year);
            invoiceMonthly.CreatedDate = DateTime.Now;
            invoiceMonthly.CreatedBy = _common.LoggedInUser.Employee;

            _repository.Add(invoiceMonthly);

            return string.Format("Invoice monthly \'{0}\' is created", invoiceMonthly.Id);
        }

        public string Update(InvoiceMonthly invoiceMonthly)
        {
            throw new NotImplementedException();
        }

        public void Validate(InvoiceMonthly invoiceMonthly)
        {
            if (invoiceMonthly.RentalAgreement == null) throw new Exception("Invoice rental agreement cannot be empty");
            if (invoiceMonthly.Discount > 0 && invoiceMonthly.DiscountRemark == string.Empty) throw new Exception("Discount remark must be filled");
        }

        public IList<InvoiceMonthly> GetAll()
        {
            var invoices = _repository.GetAll();

            return invoices.Any() ? invoices.ToList() : null;
        }

        public IList<InvoiceMonthly> Get(string id)
        {
            var invoices = _repository.Get(inv => inv.Id == id);

            return invoices.Any() ? invoices.ToList() : null;
        }

        public IList<InvoiceMonthly> Get(Expression<Func<InvoiceMonthly, bool>> predicate)
        {
            var invoices = _repository.Get(predicate);

            return invoices.Any() ? invoices.ToList() : null;
        }

        public Customer GetCustomer(string id, DateTime invoiceDate)
        {
            var customerQuery = _customerRepository.Get(cust => cust.Id == id);

            if (!customerQuery.Any()) throw new Exception("Customer not found");

            return GetCustomer(customerQuery.First(), invoiceDate);
        }

        private InvoiceMonthly GetLastInvoiceForCustomer(Customer customer)
        {
            var result = _repository.Get(inv => inv.RentalAgreement.Customer == customer).OrderByDescending(inv => inv.InvoiceDate);

            return result.Any() ? result.First() : null;
        }

        public Customer GetCustomer(Customer customer, DateTime invoiceDate)
        {
            if (!customer.HasRentalAgreement()) 
                throw new Exception(string.Format("Customer \'{0}\' has no active agreement", customer.Name));

            var activeRental = customer.GetActiveRental();
            var lastInvoiceMonthly = GetLastInvoiceForCustomer(customer);

            if (lastInvoiceMonthly == null)
            {
                if ((invoiceDate - activeRental.AgreementDate).TotalDays < 30)
                    throw new Exception(string.Format("Cannot invoice customer \'{0}\' before 1 month after agreement", customer.Name));
                
                var rentalCutOffDate = DateTimeHelper.GetDateTime(activeRental.CutOffDate
                    , invoiceDate.Month
                    , DateTime.Now.Year);
            }
            else
            {
                var rentalCutOffDate = activeRental.CutOffDate;
                var periodFrom = rentalCutOffDate > invoiceDate.Date.Day ?
                                DateTimeHelper.GetDateTime(rentalCutOffDate, invoiceDate.PreviousMonth(2).Month, DateTime.Now.Year).AddDays(1) :
                                DateTimeHelper.GetDateTime(rentalCutOffDate, invoiceDate.PreviousMonth().Month, DateTime.Now.Year);
                var periodTo = DateTimeHelper.GetDateTime(
                                periodFrom.Date.AddDays(-1).Day
                                , periodFrom.NextMonth().Month
                                , periodFrom.NextMonth().Month < periodFrom.Month ? periodFrom.Year : periodFrom.Year + 1);

                if (periodTo.Month - lastInvoiceMonthly.Period.Month > 1)
                    throw new Exception(string.Format("Must create invoice for {0} first"
                        , lastInvoiceMonthly.InvoiceDate.NextMonth().ToString("MMMM")));

                var invoiceQuery = _repository.Get(inv => inv.RentalAgreement == activeRental && inv.Period.Month == periodTo.Month);
                var isAlreadyInvoiced = invoiceQuery.Any();

                if (isAlreadyInvoiced)
                    throw new Exception(string.Format("Customer \'{0}\' is already invoiced by \'{1}\' for period {2}"
                        , customer.Name
                        , invoiceQuery.First().Id
                        , invoiceQuery.First().Period.ToString("dd-MMMM-yyyy")));
            }

            return customer;
        }

        public IList<RentalProduct> GetProducts(Customer customer, DateTime invoiceDate)
        {
            var rentalProducts = new List<RentalProduct>();
            var customerRentalProducts = _productRepository.Get(prod => prod.Customer == customer);
            var activeRental = customer.GetActiveRental();
            var rentalCutOffDate = activeRental.CutOffDate;
            var periodFrom = rentalCutOffDate > invoiceDate.Date.Day ?
                            DateTimeHelper.GetDateTime(rentalCutOffDate, invoiceDate.PreviousMonth(2).Month, DateTime.Now.Year).AddDays(1) :
                            DateTimeHelper.GetDateTime(rentalCutOffDate, invoiceDate.PreviousMonth().Month, DateTime.Now.Year).AddDays(1);
            var periodTo = DateTimeHelper.GetDateTime(
                            periodFrom.Date.Day
                            , periodFrom.NextMonth().Month
                            , periodFrom.NextMonth().Month > periodFrom.Month ? periodFrom.Year : periodFrom.Year + 1).AddDays(-1);
            var lastInvoiceMonthly = GetLastInvoiceForCustomer(customer);
            var withdrawals = lastInvoiceMonthly == null 
                ? _withdrawalRepository.GetAll() 
                : _withdrawalRepository.Get(with => with.Customer == customer);
            var receipts = lastInvoiceMonthly == null 
                ? _receiptRepository.GetAll() 
                : _receiptRepository.Get(rcpt => rcpt.RentalAgreement.Customer == customer);
            var adjustments = lastInvoiceMonthly == null 
                ? _adjustmentRepository.GetAll() 
                : _adjustmentRepository.Get(adj => adj.Customer == customer);

            foreach (var rentalProduct in customerRentalProducts)
            {
                var product = rentalProduct;
                var initialBalance = 0;

                if (lastInvoiceMonthly != null)
                {
                    var productQuery = lastInvoiceMonthly.Details.Where(dtl => dtl.RentalProduct.Id == product.Id);
                    
                    if (productQuery.Any())
                    {
                        var productQueryResult = productQuery.First();
                        initialBalance = productQueryResult.Quantity;
                    }
                }

                product.Stock = initialBalance;

                rentalProducts.Add(product);
            }

            if (withdrawals.Any())
            {
                foreach (var rentalWithdrawal in withdrawals.ToList())
                {
                    if (rentalWithdrawal.WithdrawalDate.IsBetween(periodFrom, periodTo))
                    {
                        foreach (var rentalProduct in rentalProducts)
                        {
                            var withdrawalDetail = rentalWithdrawal.Details.FirstOrDefault(dtl => dtl.RentalProduct.Id == rentalProduct.Id);
                            rentalProduct.Stock -= withdrawalDetail != null ? withdrawalDetail.Quantity : 0;
                        }
                    }
                }
            }

            if (receipts.Any())
            {
                foreach (var rentalReceipt in receipts.ToList())
                {
                    if (rentalReceipt.ReceiptDate.IsBetween(periodFrom, periodTo))
                    {
                        foreach (var rentalProduct in rentalProducts)
                        {
                            var receiptDetail = rentalReceipt.Details.FirstOrDefault(dtl => dtl.RentalProduct.Id == rentalProduct.Id);
                            rentalProduct.Stock += receiptDetail != null ? receiptDetail.Quantity : 0;
                        }   
                    }
                }   
            }

            if (adjustments.Any())
            {
                foreach (var rentalProductAdjustment in adjustments.ToList())
                {
                    if (rentalProductAdjustment.CreatedDate.IsBetween(periodFrom, periodTo))
                    {
                        foreach (var rentalProduct in rentalProducts)
                        {
                            var adjustmentDetail = rentalProductAdjustment.Details.FirstOrDefault(dtl => dtl.RentalProduct.Id == rentalProduct.Id);
                            rentalProduct.Stock += adjustmentDetail != null ? adjustmentDetail.AdjustedStock - adjustmentDetail.PreviousStock : 0;
                        }   
                    }
                }   
            }

            if (rentalProducts.Count == 0)
                throw new Exception("Customer has no rental product");

            return rentalProducts;
        }

        public double GetProductPrice(RentalAgreement activeRental, RentalProduct product)
        {
            return activeRental.Details.First(dtl => dtl.Category.Category == product.ProductCategory.Category && dtl.Subcategory.Subcategory == product.ProductSubcategory.Subcategory).Price;
        }

        public RentalProduct GetRentalProduct(string id)
        {
            var products = _productRepository.Get(prod => prod.Id == id);

            return products.FirstOrDefault();
        }
    }
}
