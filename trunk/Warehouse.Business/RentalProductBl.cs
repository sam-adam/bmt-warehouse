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
    using Warehouse.Helper;

    public class RentalProductBl : IRentalProductBl
    {
        private readonly Common _common;
        private readonly IRentalProductRepository _repository;

        public RentalProductBl(IRentalProductRepository repository, Common common)
        {
            _repository = repository;
            _common = common;
        }

        public string GenerateNewId()
        {
            var currentMonth = DateTimeHelper.ConvertMonthToAlphabet(DateTime.Now.Month);
            var currentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var newId = "001";

            var productList = _repository.Get(prod => prod.CreatedDate.Month == DateTime.Now.Month).ToList();

            var lastProduct = productList.Any() ? productList.Last() : null;

            if (lastProduct != null)
            {
                var lastId = lastProduct.Id.Substring(4);
                var newIntId = int.Parse(lastId) + 1;

                if (newIntId < 10)
                {
                    newId = "00" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else if (newIntId < 100)
                {
                    newId = "0" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    newId = newIntId.ToString(CultureInfo.InvariantCulture);
                }
            }

            return string.Format("R{0}{1}{2}", currentMonth, currentYear, newId);
        }

        public string Save(RentalProduct rentalProduct)
        {
            Validate(rentalProduct);

            rentalProduct.Id = GenerateNewId();
            rentalProduct.CreatedBy = _common.LoggedInUser.Employee;

            _repository.Add(rentalProduct);

            return rentalProduct.Id;
        }

        public string Update(RentalProduct rentalProduct)
        {
            Validate(rentalProduct);

            _repository.Update(rentalProduct);

            return string.Format("Product \'{0}\' is updated'", rentalProduct.Id);
        }

        public void Validate(RentalProduct rentalProduct)
        {
            if (rentalProduct.ProductCategory == null) throw new Exception("Product category cannot be empty");
            if (rentalProduct.ProductSubcategory == null) throw new Exception("Product category cannot be empty");
            if (rentalProduct.Brand == null) throw new Exception("Product category cannot be empty");
            if (rentalProduct.Description == null) throw new Exception("Product category cannot be empty");
        }

        public IList<RentalProduct> GetAll()
        {
            var rentalProducts = _repository.GetAll();

            return rentalProducts.Any() ? rentalProducts.ToList() : null;
        }

        public IList<RentalProduct> Get(string id)
        {
            var rentalProducts = _repository.Get(prod => prod.Id == id);

            return rentalProducts.Any() ? rentalProducts.ToList() : null;
        }

        public IList<RentalProduct> Get(Expression<Func<RentalProduct, bool>> predicate)
        {
            var rentalProducts = _repository.Get(predicate);

            return rentalProducts.Any() ? rentalProducts.ToList() : null;
        }
    }
}
