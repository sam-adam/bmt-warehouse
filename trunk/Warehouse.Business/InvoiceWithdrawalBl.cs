namespace Warehouse.Business
{
    using Warehouse.Business.Contract;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Helper;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;

    public class InvoiceWithdrawalBl : IInvoiceWithdrawalBl
    {
        private readonly Common _common;
        private readonly IInvoiceWithdrawalRepository _repository;

        public InvoiceWithdrawalBl(Common common, IInvoiceWithdrawalRepository repository)
        {
            _common = common;
            _repository = repository;
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

            return string.Format("IW{0}/{1}{2}.{3}", branch, currentMonth, currentYear, newId);
        }

        public string Save(InvoiceWithdrawal invoiceWithdrawal)
        {
            Validate(invoiceWithdrawal);

            invoiceWithdrawal.CreatedBy = _common.LoggedInUser.Employee;

            _repository.Add(invoiceWithdrawal);

            return string.Format("Invoice withdrawal \'{0}\' is created", invoiceWithdrawal.Id);
        }

        public string Update(InvoiceWithdrawal invoiceWithdrawal)
        {
            Validate(invoiceWithdrawal);

            _repository.Update(invoiceWithdrawal);

            return string.Format("Invoice withdrawal \'{0}\' is updated", invoiceWithdrawal.Id);
        }

        public void Validate(InvoiceWithdrawal invoiceWithdrawal)
        {
            if (string.IsNullOrEmpty(invoiceWithdrawal.Id)) throw new Exception("Invoice withdrawal id cannot be empty");
        }

        public IList<InvoiceWithdrawal> GetAll()
        {
            var invoiceWithdrawals = _repository.GetAll();

            return invoiceWithdrawals.Any() ? invoiceWithdrawals.ToList() : null;
        }

        public IList<InvoiceWithdrawal> Get(string id)
        {
            var invoiceWithdrawals = _repository.Get(inv => inv.Id == id);

            return invoiceWithdrawals.Any() ? invoiceWithdrawals.ToList() : null;
        }

        public IList<InvoiceWithdrawal> Get(Expression<Func<InvoiceWithdrawal, bool>> predicate)
        {
            var invoiceWithdrawals = _repository.Get(predicate);

            return invoiceWithdrawals.Any() ? invoiceWithdrawals.ToList() : null;
        }
    }
}
