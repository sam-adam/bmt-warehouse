namespace Warehouse.Data.Repository
{
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class RentalWithdrawalRepository : Repository<RentalWithdrawal>, IRentalWithdrawalRepository
    {
        public RentalWithdrawalRepository(ISession session) : base(session)
        {
        }
    }
}
