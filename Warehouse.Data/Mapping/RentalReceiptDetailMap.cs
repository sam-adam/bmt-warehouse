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
                .KeyReference(x => x.RentalReceipt, "id_rentalreceipt")
                .KeyReference(x => x.RentalProduct, "id_rentalproduct");
            Map(x => x.Remark);
            Map(x => x.Quantity);
        }
    }
}
