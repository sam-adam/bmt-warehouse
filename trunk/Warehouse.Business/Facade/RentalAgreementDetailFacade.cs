namespace Warehouse.Business.Facade
{
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using System.Linq;

    public class RentalAgreementDetailFacade
    {
        private readonly IProductCategoryBl _productCategoryBl;
        private readonly IProductSubcategoryBl _productSubcategoryBl;

        public RentalAgreementDetailFacade(IProductCategoryBl productCategoryBl, IProductSubcategoryBl productSubcategoryBl)
        {
            _productCategoryBl = productCategoryBl;
            _productSubcategoryBl = productSubcategoryBl;
        }

        public ProductCategory GetSingleCategory(string productCategoryId)
        {
            var productCategory = _productCategoryBl.Get(cat => cat.Id == productCategoryId);

            return productCategory != null ? productCategory.First() : null;
        }

        public string GetCategoryName(string productCategoryId)
        {
            var productCategory = GetSingleCategory(productCategoryId);

            return productCategory != null ? productCategory.Category : string.Empty;
        }

        public ProductSubcategory GetSingleSubcategory(string productSubcategoryId)
        {
            var productSubcategory = _productSubcategoryBl.Get(sub => sub.Id == productSubcategoryId);

            return productSubcategory != null ? productSubcategory.First() : null;
        }

        public string GetSubcategoryName(string productSubcategoryId)
        {
            var productSubcategory = GetSingleSubcategory(productSubcategoryId);

            return productSubcategory != null ? productSubcategory.Subcategory : string.Empty;
        }
    }
}
