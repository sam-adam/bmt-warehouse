namespace Warehouse.Business
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Collections.Generic;
    using Warehouse.Data.Model;
    using Warehouse.Data.Contract;
    using Warehouse.Helper;

    public class RentalAgreementBl
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductSubcategoryRepository _productSubcategoryRepository;
        private readonly IRentalAgreementRepository _rentalAgreementRepository;
        private readonly Common _common;

        private readonly List<Customer> _customers;
        private readonly List<ProductCategory> _productCategories;
        private readonly List<ProductSubcategory> _productSubcategories;
        private readonly List<RentalAgreementDetail> _details = new List<RentalAgreementDetail>();

        private Customer _selectedCustomer;
        private RentalAgreement _rentalAgreement;
        
        public RentalAgreementBl(ICustomerRepository customerRepository,
                                 IProductCategoryRepository productCategoryRepository,
                                 IProductSubcategoryRepository productSubcategoryRepository,
                                 IRentalAgreementRepository rentalAgreementRepository,
                                 Common common)
        {
            _customerRepository = customerRepository;
            _productCategoryRepository = productCategoryRepository;
            _productSubcategoryRepository = productSubcategoryRepository;
            _rentalAgreementRepository = rentalAgreementRepository;
            _common = common;

            _customers = _customerRepository.GetAll().ToList();
            _productCategories = _productCategoryRepository.GetAll().ToList();
            _productSubcategories = _productSubcategoryRepository.GetAll().ToList();
        }

        public Customer GetCustomer(Func<Customer, bool> predicate)
        {
            var customer = _customers.Where(predicate).ToList();

            if (!customer.Any())
            {
                return null;
            }

            _selectedCustomer = customer.First();

            return _selectedCustomer;
        }

        public ProductCategory GetProductCategory(Func<ProductCategory, bool> predicate)
        {
            var productCategory = _productCategories.Where(predicate).ToList();

            return productCategory.Any() ? productCategory.First() : null;
        }

        public ProductSubcategory GetProductSubcategory(string subcategoryId, ProductCategory productCategory)
        {
            var productSubcategory = _productSubcategories.Where(subcat => subcat.Id == subcategoryId).ToList();

            if (!productSubcategory.Any())
            {
                return null;
            }
            
            if (productSubcategory.All(subcat => subcat.Category.Id != productCategory.Id))
            {
                throw new ApplicationException(string.Format("Subcategory \'{0}\' is not found in category \'{1}\'", productSubcategory.First().Subcategory, productCategory.Category));
            }

            return productSubcategory.First();
        }

        public ProductSubcategory GetProductSubcategory(Func<ProductSubcategory, bool> predicate)
        {
            var productSubcategory = _productSubcategories.Where(predicate).ToList();

            return productSubcategory.Any() ? productSubcategory.First() : null;
        }

        public void AddNewRentalAgreement(DateTime agreementDate, int cutOffDate, string reference)
        {
            _rentalAgreement = new RentalAgreement(_details)
                {
                    Id = GenerateNewId(),
                    Customer = _selectedCustomer,
                    AgreementDate = agreementDate,
                    CreatedDate = DateTime.Now,
                    CutOffDate = cutOffDate,
                    Reference = reference,
                    CreatedBy = _common.LoggedInUser.Employee,
                    Status = "ACTIVE"
                };
        }

        public void AddNewRentalAgreementDetail(string categoryId, string subCategoryId, double price)
        {
            _details.Add(new RentalAgreementDetail()
                {
                    RentalAgreement = _rentalAgreement,
                    Category = GetProductCategory(cat => cat.Id == categoryId),
                    Subcategory = GetProductSubcategory(sub => sub.Id == subCategoryId),
                    Price = price
                });
        }

        public string SaveNewRentalAgreement()
        {
            var message = "";

            _rentalAgreementRepository.Add(_rentalAgreement);

            message = string.Format("Rental Agreement : {0} is created", _rentalAgreement.Id);

            if (_rentalAgreement.Customer.HasRentalAgreement())
            {
                var activeRental = _rentalAgreement.Customer.GetActiveRental();

                activeRental.Status = "INACTIVE";

                _rentalAgreementRepository.Update(activeRental);

                var updateMessage = string.Format("Rental Agreement : {0} is now inactive", activeRental.Id);

                message = message + Environment.NewLine + updateMessage;
            }

            return message;
        }

        private string GenerateNewId()
        {
            var currentMonth = DateTimeHelper.ConvertMonthToAlphabet(DateTime.Now.Month);
            var currentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var branch = _common.LoggedInUser.Employee.Branch;
            var newId = "0001";

            var rentalList = _rentalAgreementRepository.Get(rent => rent.CreatedDate.Month == DateTime.Now.Month).ToList();
            var lastRental = rentalList.Any() ? rentalList.Last() : null;

            if (lastRental != null)
            {
                string[] lastRentalId = lastRental.Id.Split('.');

                var newIntId = int.Parse(lastRentalId[1]) + 1;

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

                return string.Format("{0}{1}/{2}{3}.{4}", "RA", branch, currentMonth, currentYear, newId);
            }

            return string.Format("{0}{1}/{2}{3}.{4}", "RA", branch, currentMonth, currentYear, newId);
        }
    }
}
