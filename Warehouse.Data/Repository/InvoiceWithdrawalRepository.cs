namespace Warehouse.Data.Repository
{
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    
    public class InvoiceWithdrawalRepository : Repository<InvoiceWithdrawal>, IInvoiceWithdrawalRepository
    {
        public InvoiceWithdrawalRepository(ISession session) : base(session)
        {
        }
    }
}
