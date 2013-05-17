namespace Warehouse.Business
{
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public class CustomerBl
    {
        private readonly ICustomerRepository _customerRepository ;
        private List<Customer> _customers;

        public CustomerBl(ICustomerRepository customerRepository)
        {
            if (customerRepository == null)
            {
                throw new ArgumentNullException("customerRepository");
            }

            _customerRepository = customerRepository;
        }

        public List<Customer> GetCustomers()
        {
            _customers = _customerRepository.GetAll().ToList();

            return _customers.Any() ? _customers : null;
        } 

        public List<Customer> GetCustomers(Expression<Func<Customer, bool>>  predicate)
        {
            _customers = _customerRepository.Get(predicate).ToList();

            return _customers.Any() ? _customers : null;
        }
    }
}
