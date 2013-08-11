namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalProductAdjusmentDetailMap : ClassMap<RentalProductAdjusmentDetail>
    {
        public RentalProductAdjusmentDetailMap()
        {
            Table("tbl_detailrentalproductadjustment");

            CompositeId()
                .KeyReference(x => x.RentalProductAdjusment, "id_rentalproductadjustment")
                .KeyReference(x => x.RentalProduct, "id_rentalproduct");
            Map(x => x.PreviousStock, "previous_stock");
            Map(x => x.AdjustedStock, "adjusted_stock");
        }
    }
}
