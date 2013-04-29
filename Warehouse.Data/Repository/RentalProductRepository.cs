using NHibernate;

namespace Warehouse.Data.Repository
{
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class RentalProductRepository : Repository<RentalProduct>, IRentalProductRepository
    {
        public RentalProductRepository(ISession session) : base(session)
        {
        }
    }
}
