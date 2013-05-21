namespace Warehouse.Business
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class ProductCategoryBl : IProductCategoryBl
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryBl(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public string GenerateNewId()
        {
            var newId = "001";
            var lastCategory = GetAll()
                .OrderByDescending(cat => cat.Id)
                .FirstOrDefault();

            if (lastCategory != null)
            {
                var lastCategoryId = int.Parse(lastCategory.Id.Substring(3, 3));
                var newCategoryId = lastCategoryId + 1;

                if (newCategoryId < 10)
                {
                    newId = "00" + newCategoryId.ToString(CultureInfo.InvariantCulture);
                }
                else if (newCategoryId < 100)
                {
                    newId = "0" + newCategoryId.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    newId = newCategoryId.ToString(CultureInfo.InvariantCulture);
                }
            }

            return string.Format("CAT{0}", newId);
        }

        public string Save(ProductCategory productCategory)
        {
            Validate(productCategory);
            ValidateNew(productCategory);

            _productCategoryRepository.Add(productCategory);

            return string.Format("Product Category {0} : {1} is created", productCategory.Id, productCategory.Category);
        }

        public string Update(ProductCategory productCategory)
        {
            Validate(productCategory);

            _productCategoryRepository.Update(productCategory);

            return string.Format("Product Category {0} : {1} is updated", productCategory.Id, productCategory.Category);
        }

        public void Validate(ProductCategory productCategory)
        {
            if (productCategory == null) throw new Exception("Product category is empty");
            if (string.IsNullOrEmpty(productCategory.Category)) throw new Exception("Product category name cannot be empty");
        }

        private void ValidateNew(ProductCategory productCategory)
        {
            if (Get(cat => cat.Category == productCategory.Category).Any()) throw new Exception(string.Format("Product category {0} is already exist", productCategory.Category));
        }

        public IList<ProductCategory> GetAll()
        {
            var productCategoryList = _productCategoryRepository.GetAll();

            return productCategoryList.Any() ? productCategoryList.ToList() : null;
        }

        public IList<ProductCategory> Get(string id)
        {
            var productCategoryList = _productCategoryRepository.Get(cat => cat.Id == id);

            return productCategoryList.Any() ? productCategoryList.ToList() : null;
        }

        public IList<ProductCategory> Get(Expression<Func<ProductCategory, bool>> predicate)
        {
            var productCategoryList = _productCategoryRepository.Get(predicate);

            return productCategoryList.Any() ? productCategoryList.ToList() : null;
        }
    }
}
