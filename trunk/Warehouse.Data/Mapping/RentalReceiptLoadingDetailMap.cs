namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalReceiptLoadingDetailMap : ClassMap<RentalReceiptLoadingDetail>
    {
        public RentalReceiptLoadingDetailMap()
        {
            Table("tbl_detailrentalreceiptloading");

            CompositeId()
                .KeyReference(x => x.RentalReceipt, "id_rentalreceipt")
                .KeyProperty(x => x.Description);
            Map(x => x.Price);
        }
    }
}
