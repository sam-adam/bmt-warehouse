namespace Warehouse.Presentation.Contract
{
    using System;
    using System.Collections.Generic;
    using Warehouse.Business.Model;
    using Warehouse.Data.Model;

    public interface IMutationViewForm
    {
        Customer Customer { get; set; }
        string CustomerIdInput { get; set; }
        string SelectedProductId { get; }

        IList<RentalProduct> RentalProducts { set; }
        IList<MutationIn> MutationsIn { set; }
        IList<MutationOut> MutationsOut { set; }
    }
}
