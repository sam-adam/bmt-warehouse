namespace Warehouse.Data.Repository
{
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class RentalAgreementRepository : Repository<RentalAgreement>, IRentalAgreementRepository
    {
        public RentalAgreementRepository(ISession session) : base(session)
        {

        }
    }
}
