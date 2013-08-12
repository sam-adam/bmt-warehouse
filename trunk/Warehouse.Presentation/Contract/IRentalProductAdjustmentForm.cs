namespace Warehouse.Presentation.Contract
{
    using System.Collections.Generic;
    using Warehouse.Data.Model;

    public interface IRentalProductAdjustmentForm
    {
        Customer Customer { get; set; }
        string CustomerIdInput { get; set; }
        List<RentalProductAdjusmentDetail> Details { get; set; } 
    }
}
