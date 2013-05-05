namespace Warehouse.Data.Repository
{
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ISession session) : base(session)
        {
        }
    }
}
