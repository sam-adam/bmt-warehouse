namespace Warehouse.Business
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class CustomerBl : ICustomerBl
    {
        private readonly ICustomerRepository _customerRepository;
        private List<Customer> _customers;

        public CustomerBl(ICustomerRepository customerRepository)
        {
            if (customerRepository == null)
            {
                throw new ArgumentNullException("customerRepository");
            }

            _customerRepository = customerRepository;
        }

        public string GenerateNewId()
        {
            var newId = "001";
            var lastCustomer = GetAll()
                .OrderByDescending(cust => cust.JoinDate)
                .FirstOrDefault();

            if (lastCustomer != null)
            {
                var lastCustomerId = int.Parse(lastCustomer.Id.Substring(3, 3));
                var newCustomerId = lastCustomerId + 1;

                if (newCustomerId < 10)
                {
                    newId = "00" + newCustomerId.ToString(CultureInfo.InvariantCulture);
                }
                else if (newCustomerId < 100)
                {
                    newId = "0" + newCustomerId.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    newId = newCustomerId.ToString(CultureInfo.InvariantCulture);
                }
            }

            return string.Format("CUS{0}", newId);
        }

        public string Save(Customer customer)
        {
            Validate(customer);

            _customerRepository.Add(customer);

            return string.Format("Customer : {0} is created.", customer.Id);
        }

        public string Update(Customer customer)
        {
            Validate(customer);

            _customerRepository.Update(customer);

            return string.Format("Customer : {0} is updated.", customer.Id);
        }

        public void Validate(Customer customer)
        {
            if (customer == null) throw new NullReferenceException("Customer is empty");
            if (string.IsNullOrEmpty(customer.Name)) throw new Exception("Customer name is empty");
        }

        public IList<Customer> GetAll()
        {
            _customers = _customerRepository.GetAll().ToList();

            return _customers.Any() ? _customers : null;
        }

        public IList<Customer> Get(string id)
        {
            _customers = _customerRepository.Get(cust => cust.Id == id).ToList();

            return _customers.Any() ? _customers : null;
        }

        public IList<Customer> Get(Expression<Func<Customer, bool>> predicate)
        {
            _customers = _customerRepository.Get(predicate).ToList();

            return _customers.Any() ? _customers : null;
        }
    }
}
