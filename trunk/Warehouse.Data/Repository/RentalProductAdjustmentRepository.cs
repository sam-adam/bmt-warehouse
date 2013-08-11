using NHibernate;

namespace Warehouse.Data.Repository
{
    using Warehouse.Data.Model;

    public class RentalProductAdjustmentRepository : Repository<RentalProductAdjustment>
    {
        public RentalProductAdjustmentRepository(ISession session) : base(session)
        {
        }
    }
}
