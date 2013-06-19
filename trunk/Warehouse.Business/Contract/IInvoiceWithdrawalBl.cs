namespace Warehouse.Business.Contract
{
    using Warehouse.Data.Model;

    public interface IInvoiceWithdrawalBl : IBusinessLogic<InvoiceWithdrawal>, IReadOnlyBusinessLogic<InvoiceWithdrawal>
    {
        InvoiceWithdrawal GetSingle(string id);
    }
}
