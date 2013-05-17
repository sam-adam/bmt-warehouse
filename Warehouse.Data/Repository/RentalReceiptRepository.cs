namespace Warehouse.Data.Repository
{
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class RentalReceiptRepository : Repository<RentalReceipt>, IRentalReceiptRepository
    {
        public RentalReceiptRepository(ISession session) : base(session)
        {
        }
    }
}
