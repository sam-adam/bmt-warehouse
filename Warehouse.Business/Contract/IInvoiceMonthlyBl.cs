namespace Warehouse.Business.Contract
{
    using System.Collections.Generic;
    using Warehouse.Data.Model;

    public interface IInvoiceMonthlyBl : IBusinessLogic<InvoiceMonthly>, IReadOnlyBusinessLogic<InvoiceMonthly>
    {
        Customer GetCustomer(string id);
        Customer GetCustomer(Customer customer);
        IList<RentalProduct> GetProducts(Customer customer);
        double GetProductPrice(RentalAgreement activeRental, RentalProduct product);
        RentalProduct GetRentalProduct(string id);
    }
}
