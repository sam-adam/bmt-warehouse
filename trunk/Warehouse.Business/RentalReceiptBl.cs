﻿namespace Warehouse.Business
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using Warehouse.Business.Contract;
    using Warehouse.Data.Model;
    using Warehouse.Data.Contract;
    using Warehouse.Helper;

    public class RentalReceiptBl : IRentalReceiptBl
    {
        private readonly Common _common;
        private readonly IRentalReceiptRepository _rentalReceiptRepository;
        private readonly IRentalProductBl _rentalProductBl;

        public RentalReceiptBl(Common common, IRentalReceiptRepository rentalReceiptRepository, IRentalProductBl rentalProductBl)
        {
            _common = common;
            _rentalReceiptRepository = rentalReceiptRepository;
            _rentalProductBl = rentalProductBl;
        }

        public string GenerateNewId()
        {
            var currentMonth = DateTimeHelper.ConvertMonthToAlphabet(DateTime.Now.Month);
            var currentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var branch = _common.LoggedInUser.Employee.Branch;
            var newId = "0001";

            var rentalList = _rentalReceiptRepository.Get(rent => rent.CreatedDate.Month == DateTime.Now.Month).ToList();
            var lastRental = rentalList.Any() ? rentalList.Last() : null;

            if (lastRental != null)
            {
                var lastRentalIds = lastRental.Id.Split('.');
                var newIntId = int.Parse(lastRentalIds[1]) + 1;

                if (newIntId < 10)
                {
                    newId = "000" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else if (newIntId < 100)
                {
                    newId = "00" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else if (newIntId < 1000)
                {
                    newId = "0" + newIntId.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    newId = newIntId.ToString(CultureInfo.InvariantCulture);
                }
            }

            return string.Format("{0}{1}/{2}{3}.{4}", "RCP", branch, currentMonth, currentYear, newId);
        }

        public string Save(RentalReceipt rentalReceipt)
        {
            Validate(rentalReceipt);

            rentalReceipt.Status = "ACTIVE";
            rentalReceipt.CreatedDate = DateTime.Now;
            rentalReceipt.CreatedBy = _common.LoggedInUser.Employee;

            CheckRentalProduct(rentalReceipt);

            _rentalReceiptRepository.Add(rentalReceipt);

            return string.Format("Rental receipt : {0} is created", rentalReceipt.Id);
        }

        private void CheckRentalProduct(RentalReceipt rentalReceipt)
        {
            var customer = rentalReceipt.RentalAgreement.Customer;

            foreach (var detail in rentalReceipt.Details)
            {
                var detailProduct = detail.RentalProduct;

                var rentalProducts =
                    _rentalProductBl.Get(
                        prod =>
                        prod.Customer == customer && prod.ProductCategory == detailProduct.ProductCategory &&
                        prod.ProductSubcategory == detailProduct.ProductSubcategory && prod.Brand == detailProduct.Brand &&
                        prod.Description == detailProduct.Description);

                if (rentalProducts != null)
                {
                    var rentalProduct = rentalProducts.First();

                    rentalProduct.Stock += detail.Quantity;

                    detail.RentalProduct.Id = rentalProduct.Id;

                    _rentalProductBl.Update(rentalProduct);
                }
                else
                {
                    detailProduct.CreatedDate = DateTime.Now;
                    detailProduct.Stock += detail.Quantity;

                    var newProductId = _rentalProductBl.Save(detailProduct);

                    detail.RentalProduct.Id = newProductId;
                }
            }
        }

        public string Update(RentalReceipt rentalReceipt)
        {
            Validate(rentalReceipt);

            _rentalReceiptRepository.Update(rentalReceipt);

            return string.Format("Rental receipt : {0} is updated", rentalReceipt.Id);
        }

        public void Validate(RentalReceipt rentalReceipt)
        {
            if (rentalReceipt == null) throw new Exception("Rental receipt is empty");
            if (rentalReceipt.Details.Count <= 0) throw new Exception("Rental receipt detail cannot be empty");
        }

        public IList<RentalReceipt> GetAll()
        {
            var rentalReceiptList = _rentalReceiptRepository.GetAll();

            return rentalReceiptList.Any() ? rentalReceiptList.ToList() : null;
        }

        public IList<RentalReceipt> Get(string id)
        {
            var rentalReceiptList = _rentalReceiptRepository.Get(recp => recp.Id == id);

            return rentalReceiptList.Any() ? rentalReceiptList.ToList() : null;
        }

        public IList<RentalReceipt> Get(Expression<Func<RentalReceipt, bool>> predicate)
        {
            var rentalReceiptList = _rentalReceiptRepository.Get(predicate);

            return rentalReceiptList.Any() ? rentalReceiptList.ToList() : null;
        }
    }
}