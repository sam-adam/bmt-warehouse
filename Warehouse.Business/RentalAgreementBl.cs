namespace Warehouse.Business
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Collections.Generic;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Data.Model;
    using Warehouse.Data.Contract;
    using Warehouse.Helper;

    public class RentalAgreementBl : IRentalAgreementBl
    {
        private readonly Common _common;
        private readonly IRentalAgreementRepository _rentalAgreementRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly RentalAgreementDetailFacade _detailFacade;
        
        public RentalAgreementBl(IRentalAgreementRepository rentalAgreementRepository, Common common, RentalAgreementDetailFacade detailFacade, ICustomerRepository customerRepository)
        {
            _common = common;
            _rentalAgreementRepository = rentalAgreementRepository;
            _detailFacade = detailFacade;
            _customerRepository = customerRepository;
        }

        public string Save(RentalAgreement rentalAgreement)
        {
            var message = "";

            Validate(rentalAgreement);
            ValidateNew(rentalAgreement);

            rentalAgreement.Status = "ACTIVE";
            rentalAgreement.CreatedBy = _common.LoggedInUser.Employee;

            _rentalAgreementRepository.Add(rentalAgreement);

            message = string.Format("Rental Agreement : {0} is created", rentalAgreement.Id);

            if (rentalAgreement.Customer.HasRentalAgreement())
            {
                var activeRental = rentalAgreement.Customer.GetActiveRental();
                var updateMessage = "";

                activeRental.Status = "INACTIVE";

                try
                {
                    updateMessage = Update(activeRental);
                }
                catch (Exception ex)
                {
                    _rentalAgreementRepository.Delete(rentalAgreement);

                    throw new ApplicationException("Failed to insert data. Contact system administrator to check.");
                }

                message = message + Environment.NewLine + updateMessage;
            }

            return message;
        }

        public string Update(RentalAgreement rentalAgreement)
        {
            Validate(rentalAgreement);

            _rentalAgreementRepository.Update(rentalAgreement);

            return string.Format("Rental agreement : {0} is updated", rentalAgreement.Id);
        }

        public void Validate(RentalAgreement rentalAgreement)
        {
            if (rentalAgreement == null) throw new Exception("Rental agreement is empty");
            if (rentalAgreement.Details.Count <= 0) throw new Exception("Rental agreement details cannot be empty");
            if (rentalAgreement.CutOffDate <= 0) throw new Exception("Rental agreement cut-off date must be larger than 0");
            if (string.IsNullOrEmpty(rentalAgreement.Reference)) throw new Exception("Rental agreement external reference cannot be empty");
        }

        private void ValidateNew(RentalAgreement rentalAgreement)
        {
            if (_rentalAgreementRepository.Get(rag => rag.Id == rentalAgreement.Id).Any()) throw new Exception("Rental agreement is already exist");
        }

        public string GenerateNewId()
        {
            var currentMonth = DateTimeHelper.ConvertMonthToAlphabet(DateTime.Now.Month);
            var currentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var branch = _common.LoggedInUser.Employee.Branch;
            var newId = "0001";

            var rentalList = _rentalAgreementRepository.Get(rent => rent.CreatedDate.Month == DateTime.Now.Month).ToList();
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

            return string.Format("{0}{1}/{2}{3}.{4}", "RA", branch, currentMonth, currentYear, newId);
        }

        public IList<RentalAgreement> GetAll()
        {
            var rentalAgreementList = _rentalAgreementRepository.GetAll();

            return rentalAgreementList.Any() ? rentalAgreementList.ToList() : null;
        }

        public IList<RentalAgreement> Get(string id)
        {
            var rentalAgreementList = _rentalAgreementRepository.Get(rag => rag.Id == id);

            return rentalAgreementList.Any() ? rentalAgreementList.ToList() : null;
        }

        public IList<RentalAgreement> Get(Expression<Func<RentalAgreement, bool>> predicate)
        {
            var rentalAgreementList = _rentalAgreementRepository.Get(predicate);

            return rentalAgreementList.Any() ? rentalAgreementList.ToList() : null;
        }

        public Customer GetCustomer(string id)
        {
            return _customerRepository.Get(cust => cust.Id == id).FirstOrDefault();
        }

        public ProductCategory GetCategory(string id)
        {
            return _detailFacade.GetSingleCategory(id);
        }

        public ProductSubcategory GetSubcategory(string id)
        {
            return _detailFacade.GetSingleSubcategory(id);
        }

        public IList<RentalAgreement> GetAllActive()
        {
            var rentalAgreementList = _rentalAgreementRepository
                .GetAll()
                .Where(rent => rent.Status == "ACTIVE");

            return rentalAgreementList.Any() ? rentalAgreementList.ToList() : null;
        }

        public IList<RentalAgreement> GetActive(Expression<Func<RentalAgreement, bool>> predicate)
        {
            var rentalAgreementList = _rentalAgreementRepository
                .Get(predicate)
                .Where(rent => rent.Status == "ACTIVE");

            return rentalAgreementList.Any() ? rentalAgreementList.ToList() : null;
        }
    }
}
