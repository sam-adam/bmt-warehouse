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

    public class ProductSubcategoryBl : IProductSubcategoryBl
    {
        private readonly IProductSubcategoryRepository _repository;

        public ProductSubcategoryBl(IProductSubcategoryRepository repository)
        {
            _repository = repository;
        }

        public string GenerateNewId()
        {
            var newId = "001";
            var lastCategory = GetAll()
                .OrderByDescending(sub => sub.Id)
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

            return string.Format("SUB{0}", newId);
        }

        public string Save(ProductSubcategory productSubcategory)
        {
            Validate(productSubcategory);
            ValidateNew(productSubcategory);

            _repository.Add(productSubcategory);

            return string.Format("Product Subcategory {0} : {1} is created", productSubcategory.Id, productSubcategory.Category);
        }

        public string Update(ProductSubcategory productSubcategory)
        {
            Validate(productSubcategory);

            _repository.Update(productSubcategory);

            return string.Format("Product Subcategory {0} : {1} is created", productSubcategory.Id, productSubcategory.Category);
        }

        public void Validate(ProductSubcategory productSubcategory)
        {
            if (productSubcategory == null) throw new Exception("Product subcategory is empty");
            if (string.IsNullOrEmpty(productSubcategory.Subcategory)) throw new Exception("Product subcategory name cannot be empty");
        }

        private void ValidateNew(ProductSubcategory productSubcategory)
        {
            if (Get(sub => sub.Category == productSubcategory.Category).Any()) throw new Exception(string.Format("Product subcategory {0} is already exist", productSubcategory.Category));
        }

        public IList<ProductSubcategory> GetAll()
        {
            var productSubcategoryList = _repository.GetAll();

            return productSubcategoryList.Any() ? productSubcategoryList.ToList() : null;
        }

        public IList<ProductSubcategory> Get(string id)
        {
            var productSubcategoryList = _repository.Get(sub => sub.Id == id);

            return productSubcategoryList.Any() ? productSubcategoryList.ToList() : null;
        }

        public IList<ProductSubcategory> Get(Expression<Func<ProductSubcategory, bool>> predicate)
        {
            var productSubcategoryList = _repository.Get(predicate);

            return productSubcategoryList.Any() ? productSubcategoryList.ToList() : null;
        }
    }
}
