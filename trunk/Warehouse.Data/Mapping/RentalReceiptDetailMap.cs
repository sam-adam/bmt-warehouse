﻿namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalReceiptDetailMap : ClassMap<RentalReceiptDetail>
    {
        public RentalReceiptDetailMap()
        {
            Table("tbl_detailrentalreceipt");

            CompositeId()
                .KeyReference(x => x.RentalReceipt, "id_rentalreceipt")
                .KeyReference(x => x.ProductCategory, "id_category")
                .KeyReference(x => x.ProductSubcategory, "id_subcategory");
            Map(x => x.Brand);
            Map(x => x.Description);
            Map(x => x.Remark);
            Map(x => x.Quantity);
        }
    }
}
