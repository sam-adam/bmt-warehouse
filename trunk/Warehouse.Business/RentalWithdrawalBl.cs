namespace Warehouse.Business
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Globalization;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Business.Model;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Helper;

    public class RentalWithdrawalBl : IRentalWithdrawalBl
    {
        private readonly Common _common;
        private readonly IRentalWithdrawalRepository _repository;
        private readonly RentalWithdrawalFacade _facade;

        private IList<CustomerRentalItem> _rentalItems;

        public RentalWithdrawalBl(Common common, IRentalWithdrawalRepository repository, RentalWithdrawalFacade facade)
        {
            _common = common;
            _repository = repository;
            _facade = facade;
        }

        public string GenerateNewId()
        {
            var currentMonth = DateTimeHelper.ConvertMonthToAlphabet(DateTime.Now.Month);
            var currentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var branch = _common.LoggedInUser.Employee.Branch;
            var newId = "0001";

            var rentalList = _repository.Get(rent => rent.CreatedDate.Month == DateTime.Now.Month).ToList();
            var lastRental = rentalList.Any() ? rentalList.Last() : null;

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

            return string.Format("{0}{1}/{2}{3}.{4}", "RW", branch, currentMonth, currentYear, newId);
        }

        public string Save(RentalWithdrawal rentalWithdrawal)
        {
            rentalWithdrawal.Id = GenerateNewId();
            rentalWithdrawal.Status = "ACTIVE";
            rentalWithdrawal.CreatedBy = _common.LoggedInUser.Employee;

            Validate(rentalWithdrawal);
            ValidateNew(rentalWithdrawal);

            _repository.Add(rentalWithdrawal);

            return string.Format("Rental withdrawal : {0} is created", rentalWithdrawal.Id);
        }

        public string Update(RentalWithdrawal rentalWithdrawal)
        {
            Validate(rentalWithdrawal);

            _repository.Update(rentalWithdrawal);

            return string.Format("Rental withdrawal : {0} is updated", rentalWithdrawal.Id);
        }

        public void Validate(RentalWithdrawal rentalWithdrawal)
        {
            if (rentalWithdrawal == null) throw new Exception("Rental withdrawal is empty");
            if (rentalWithdrawal.Customer == null) throw new Exception("Rental withdrawal customer cannot be empty");
            if (rentalWithdrawal.Details.Count <= 0) throw new Exception("Rental withdrawal detail cannot be empty");
        }

        public void ValidateNew(RentalWithdrawal withdrawal)
        {
            
        }

        public IList<RentalWithdrawal> GetAll()
        {
            var rentalWithdrawals = _repository.GetAll();

            return rentalWithdrawals.Any() ? rentalWithdrawals.ToList() : null;
        }

        public IList<RentalWithdrawal> Get(string id)
        {
            var rentalWithdrawals = _repository.Get(recp => recp.Id == id);

            return rentalWithdrawals.Any() ? rentalWithdrawals.ToList() : null;
        }

        public IList<RentalWithdrawal> Get(Expression<Func<RentalWithdrawal, bool>> predicate)
        {
            var rentalWithdrawals = _repository.Get(predicate);

            return rentalWithdrawals.Any() ? rentalWithdrawals.ToList() : null;
        }

        public Customer GetCustomer(string id)
        {
            return _facade.GetCustomer(id);
        }

        public ProductCategory GetCategory(string id)
        {
            return _facade.GetCategory(id);
        }

        public ProductSubcategory GetSubcategory(string id)
        {
            return _facade.GetSubcategory(id);
        }

        public IList<CustomerRentalItem> GetRentalItems(string customerId)
        {
            _rentalItems = new List<CustomerRentalItem>();

            var customer = GetCustomer(customerId);

            if (customer == null) return null;

            var customerRentals = _facade.GetRentalReceipt(rent => rent.RentalAgreement.Customer == customer 
                                                               && rent.Status == "ACTIVE");

            if (customerRentals == null) return null;

            foreach (var customerRental in customerRentals)
            {
                FillRentalItems(customerRental);
            }

            CountRentalItemsStock(customer);

            return _rentalItems.Any() ? _rentalItems : null;
        }

        private void FillRentalItems(RentalReceipt rentalReceipt)
        {
            foreach (var receiptDetail in rentalReceipt.Details)
            {
                var tempRentalItem =
                        _rentalItems.FirstOrDefault(item => item.ProductCategory == receiptDetail.ProductCategory
                            && item.ProductSubcategory == receiptDetail.ProductSubcategory
                            && item.Brand == receiptDetail.Brand
                            && item.Description == receiptDetail.Description);

                if (tempRentalItem != null)
                {
                    tempRentalItem.Quantity += receiptDetail.Quantity;
                }
                else
                {
                    _rentalItems.Add(new CustomerRentalItem()
                    {
                        ProductCategory = receiptDetail.ProductCategory,
                        ProductSubcategory = receiptDetail.ProductSubcategory,
                        Brand = receiptDetail.Brand,
                        Description = receiptDetail.Description,
                        Quantity = receiptDetail.Quantity
                    });
                }
            }
        }

        private void CountRentalItemsStock(Customer customer)
        {
            var withdrawals = Get(with => with.Customer == customer);

            if (withdrawals != null)
            {
                foreach (var withdrawal in withdrawals)
                {
                    foreach (var detail in withdrawal.Details)
                    {
                        var rentalItem = _rentalItems.FirstOrDefault(item => item.ProductCategory == detail.ProductCategory
                            && item.ProductSubcategory == detail.ProductSubcategory
                            && item.Brand == detail.Brand
                            && item.Description == detail.Description);

                        if (rentalItem != null)
                        {
                            rentalItem.Quantity -= detail.Quantity;
                        }
                    }
                }   
            }
        }
    }
}
