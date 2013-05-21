namespace Warehouse.Business.Contract
{
    using Warehouse.Data.Model;

    public interface ICustomerBl : IBusinessLogic<Customer>, IReadOnlyBusinessLogic<Customer>
    {
    }
}
