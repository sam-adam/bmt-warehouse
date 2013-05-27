namespace Warehouse.Business.Contract
{
    using System.Collections.Generic;
    using Warehouse.Business.Model;
    using Warehouse.Data.Model;

    public interface IRentalWithdrawalBl : IBusinessLogic<RentalWithdrawal>, IReadOnlyBusinessLogic<RentalWithdrawal>
    {
        void ValidateNew(RentalWithdrawal withdrawal);
        Customer GetCustomer(string id);
        ProductCategory GetCategory(string id);
        ProductSubcategory GetSubcategory(string id);
        IList<CustomerRentalItem> GetRentalItems(string customerId);
    }
}