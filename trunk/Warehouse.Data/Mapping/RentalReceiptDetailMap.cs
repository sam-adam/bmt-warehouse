namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalReceiptDetailMap : ClassMap<RentalReceiptDetail>
    {
        public RentalReceiptDetailMap()
        {
            Table("tbl_detailrentalreceipt");

            CompositeId()
                .KeyReference(x => x.RentalReceipt)
                .KeyReference(x => x.ProductCategory)
                .KeyReference(x => x.ProductSubcategory);
            Map(x => x.Brand);
            Map(x => x.Description);
            Map(x => x.Quantity);
        }
    }
}
