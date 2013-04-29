namespace Warehouse.Data.Repository
{
    using NHibernate;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ISession session) : base(session)
        {
        }
    }
}
