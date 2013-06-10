namespace Warehouse.Data.Repository
{
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class InvoiceMonthlyRepository : Repository<InvoiceMonthly>, IInvoiceMonthlyRepository
    {
        public InvoiceMonthlyRepository(ISession session) : base(session)
        {
        }
    }
}
