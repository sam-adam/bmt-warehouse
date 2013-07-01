namespace Warehouse.Presentation.Delegates
{
    using System;
    using Warehouse.Data.Model;

    public class CustomerSelectedEventArgs : EventArgs
    {
        private readonly Customer _customer;

        public CustomerSelectedEventArgs(Customer customer)
        {
            _customer = customer;
        }

        public Customer Customer
        {
            get { return _customer; }
        }
    }
}
