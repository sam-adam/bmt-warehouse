namespace Warehouse.Business.Contract
{
    using Warehouse.Data.Model;

    public interface IRentalProductBl : IBusinessLogic<RentalProduct>, IReadOnlyBusinessLogic<RentalProduct>
    {
    }
}
