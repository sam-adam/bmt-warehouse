namespace Warehouse.Business.Contract
{
    using Warehouse.Data.Model;

    public interface IProductCategoryBl : IBusinessLogic<ProductCategory>, IReadOnlyBusinessLogic<ProductCategory>
    {
    }
}
