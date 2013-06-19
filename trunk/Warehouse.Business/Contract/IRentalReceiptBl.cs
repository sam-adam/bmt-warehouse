namespace Warehouse.Business.Contract
{
    using Warehouse.Data.Model;

    public interface IRentalReceiptBl : IBusinessLogic<RentalReceipt>, IReadOnlyBusinessLogic<RentalReceipt>
    {
        RentalAgreement GetCustomerActiveAgreement(string customerId);
        ProductCategory GetCategory(string id);
        ProductSubcategory GetSubcategory(string id);
    }
}
