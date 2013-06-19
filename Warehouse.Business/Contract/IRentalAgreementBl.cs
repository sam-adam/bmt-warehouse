namespace Warehouse.Business.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Warehouse.Data.Model;

    public interface IRentalAgreementBl : IBusinessLogic<RentalAgreement>, IReadOnlyBusinessLogic<RentalAgreement>
    {
        Customer GetCustomer(string id);
        ProductCategory GetCategory(string id);
        ProductSubcategory GetSubcategory(string id);
        IList<RentalAgreement> GetAllActive();
        IList<RentalAgreement> GetActive(Expression<Func<RentalAgreement, bool>> predicate);
    }
}
