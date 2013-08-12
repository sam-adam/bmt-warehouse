using System.Linq.Expressions;
using System.Windows.Forms;

namespace Warehouse.Business
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Data.Repository;

    public class RentalProductAdjustmentBl
    {
        private readonly Common _common;
        private readonly RentalProductAdjustmentRepository _repo;
        private readonly ICustomerRepository _customerRepo;
        private readonly IRentalProductRepository _rentalProductRepo;

        public RentalProductAdjustmentBl(RentalProductAdjustmentRepository repo, ICustomerRepository customerRepo, IRentalProductRepository rentalProductRepo, Common common)
        {
            _repo = repo;
            _customerRepo = customerRepo;
            _rentalProductRepo = rentalProductRepo;
            _common = common;
        }

        public Customer GetCustomer(string customerId)
        {
            return _customerRepo.Get(cust => cust.Id == customerId).FirstOrDefault();
        }

        public List<RentalProductAdjusmentDetail> GetCustomerRentalItems(Customer customer)
        {
            List<RentalProductAdjusmentDetail> details = null;

            var rentalProducts = _rentalProductRepo.Get(prod => prod.Customer == customer).ToList();

            if (rentalProducts.Count != 0)
            {
                details = new List<RentalProductAdjusmentDetail>();

                foreach (var rentalProduct in rentalProducts)
                {
                    details.Add(new RentalProductAdjusmentDetail()
                        {
                            RentalProductAdjusment = null,
                            RentalProduct = rentalProduct,
                            AdjustedStock = rentalProduct.Stock,
                            PreviousStock = rentalProduct.Stock
                        });
                }
            }

            return details;
        }

        public string GenerateNewId()
        {
            var newId = 1;
            var transList = _repo.GetAll().ToList();
            var lastTrans = transList.Any() ? transList.Last() : null;

            if (lastTrans != null)
            {
                newId = int.Parse(lastTrans.Id) + 1;
            }

            return newId.ToString(CultureInfo.InvariantCulture);
        }

        public string Save(RentalProductAdjustment rentalProductAdjustment)
        {
            rentalProductAdjustment.CreatedDate = DateTime.Now;
            rentalProductAdjustment.CreatedBy = _common.LoggedInUser.Employee;

            _repo.Add(rentalProductAdjustment);

            foreach (var itemDetail in rentalProductAdjustment.Details)
            {
                var detail = itemDetail;
                var rentalProduct = _rentalProductRepo.Get(prod => prod.Id == detail.RentalProduct.Id).First();

                rentalProduct.Stock = detail.AdjustedStock;

                _rentalProductRepo.Update(rentalProduct);
            }

            return string.Format("{0} rental products stocks adjusted", rentalProductAdjustment.Details.Count);
        }

        public IList<RentalProductAdjustment> GetAll()
        {
            var query = _repo.GetAll();

            return query.Any() ? query.ToList() : null;
        }

        public RentalProductAdjustment GetById(string id)
        {
            var query = _repo.Get(x => x.Id == id);

            return query.Any() ? query.First() : null;
        }

        public IList<RentalProductAdjustment> Get(Expression<Func<RentalProductAdjustment, bool>> predicate)
        {
            var query = _repo.Get(predicate);

            return query.Any() ? query.ToList() : null;
        }
    }
}
