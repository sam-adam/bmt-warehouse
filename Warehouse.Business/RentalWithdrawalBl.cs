namespace Warehouse.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Globalization;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Helper;

    public class RentalWithdrawalBl : IRentalWithdrawalBl
    {
        private readonly Common _common;
        private readonly IRentalWithdrawalRepository _repository;
        private readonly RentalWithdrawalFacade _facade;

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

            foreach (var detail in rentalWithdrawal.Details)
            {
                var rentalProduct = detail.RentalProduct;

                rentalProduct.Stock -= detail.Quantity;

                _facade.UpdateRentalProduct(rentalProduct);
            }

            _repository.Add(rentalWithdrawal);

            var addInvoiceWithdrawalMessage = _facade.AddInvoiceWithdrawal(rentalWithdrawal);

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
            if (string.IsNullOrEmpty(rentalWithdrawal.Reference)) throw new Exception("Rental withdrawal external reference cannot be empty");
            if (rentalWithdrawal.Details == null || rentalWithdrawal.Details.Count <= 0) throw new Exception("Rental withdrawal detail cannot be empty");
            if (rentalWithdrawal.UnloadingDetails == null || rentalWithdrawal.UnloadingDetails.Count <= 0) throw new Exception("Rental withdrawal unloading detail cannot be empty");
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

        public IList<RentalProduct> GetCustomerRentalProducts(Customer customer)
        {
            return _facade.GetCustomerRentalProducts(customer);
        }
    }
}
