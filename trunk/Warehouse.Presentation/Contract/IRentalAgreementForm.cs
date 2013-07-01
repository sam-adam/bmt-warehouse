using System;

namespace Warehouse.Presentation.Contract
{
    using Warehouse.Data.Model;

    public interface IRentalAgreementForm
    {
        string CustomerIdInput { get; set; }
        string ExternalReferenceInput { get; set; }
        DateTime RentalAgreementDateInput { get; set; }
        Customer Customer { get; set; }
        RentalAgreement RentalAgreement { get; set; }
    }
}