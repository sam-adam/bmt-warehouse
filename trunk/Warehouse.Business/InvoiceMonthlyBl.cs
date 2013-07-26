namespace Warehouse.Business
{
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
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

        public InvoiceMonthlyBl(Common common, IInvoiceMonthlyRepository repository, ICustomerRepository customerRepository, IRentalProductRepository productRepository)
        {
            _common = common;
            _repository = repository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
        }

        public string GenerateNewId()
        {
            var currentMonth = DateTimeHelper.ConvertMonthToAlphabet(DateTime.Now.Month);
            var currentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var branch = _common.LoggedInUser.Employee.Branch;
            var newId = "0001";

            var invoiceList = _repository.Get(inv => inv.CreatedDate.Month == DateTime.Now.Month).ToList();
            var lastRental = invoiceList.Any() ? invoiceList.Last() : null;

            if (lastRental != null)
            {
                var lastRentalIds = lastRental.Id.Split('.');
                var newIntId = int.Parse(lastRentalIds[1]) + 1;

                if (newIntId < 10)
                {
                    newId = "000" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else if (newIntId < 100)
                {
                    newId = "00" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else if (newIntId < 1000)
                {
                    newId = "0" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    newId = newIntId.ToString(CultureInfo.InvariantCulture);
                }
            }

            return string.Format("IM{0}/{1}{2}.{3}", branch, currentMonth, currentYear, newId);
        }

        public string Save(InvoiceMonthly invoiceMonthly)
        {
            Validate(invoiceMonthly);

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

        public Customer GetCustomer(string id)
        {
            var customerQuery = _customerRepository.Get(cust => cust.Id == id);

            if (!customerQuery.Any()) throw new Exception("Customer not found");

            return GetCustomer(customerQuery.First());
        }

        public Customer GetCustomer(Customer customer)
        {
            if (!customer.HasRentalAgreement()) throw new Exception(string.Format("Customer \'{0}\' has no active agreement", customer.Name));

            var activeRental = customer.GetActiveRental();
            var rentalCutOffDate = activeRental.CutOffDate.ToString(CultureInfo.InvariantCulture) + "/" + DateTime.Now.Month.ToString("d2") + "/" + DateTime.Now.Year;

            if (DateTime.Now < DateTime.ParseExact(rentalCutOffDate, "dd/MM/yyyy", null)) throw new Exception(string.Format("Cannot invoice customer \'{0}\' before {1}", customer.Name, rentalCutOffDate));

            var invoiceQuery = _repository.Get(inv => inv.RentalAgreement == activeRental && inv.InvoiceDate.Month == DateTime.Now.Month);
            var isAlreadyInvoiced = invoiceQuery.Any();

            if (isAlreadyInvoiced) throw new Exception(string.Format("Customer \'{0}\' is already invoiced by \'{1}\'", customer.Name, invoiceQuery.First().Id));

            return customer;
        }

        public IList<RentalProduct> GetProducts(Customer customer)
        {
            var products = _productRepository.Get(prod => prod.Customer == customer);

            return products.Any() ? products.ToList() : null;
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
