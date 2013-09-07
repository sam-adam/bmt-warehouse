namespace Warehouse.Business.Contract
{
    using System;
    using System.Collections.Generic;
    using Warehouse.Data.Model;

    public interface IInvoiceMonthlyBl : IBusinessLogic<InvoiceMonthly>, IReadOnlyBusinessLogic<InvoiceMonthly>
    {
        Customer GetCustomer(string id, DateTime invoiceDate);
        Customer GetCustomer(Customer customer, DateTime invoiceDate);
        IList<RentalProduct> GetProducts(Customer customer, DateTime invoiceDate);
        double GetProductPrice(RentalAgreement activeRental, RentalProduct product);
        RentalProduct GetRentalProduct(string id);
    }
}
