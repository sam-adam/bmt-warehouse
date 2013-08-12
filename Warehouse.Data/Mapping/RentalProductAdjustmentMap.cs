namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalProductAdjustmentMap : ClassMap<RentalProductAdjustment>
    {
        public RentalProductAdjustmentMap()
        {
            Table("tbl_trrentalproductadjustment");

            Id(x => x.Id, "id_rentalproductadjustment");
            References(x => x.Customer, "id_customer")
                .Not.LazyLoad();
            Map(x => x.CreatedDate, "created_date");
            References(x => x.CreatedBy, "created_by")
                .Not.LazyLoad();
            HasMany(x => x.Details)
                .KeyColumn("id_rentalproductadjustment")
                .Cascade.All()
                .Inverse();
        }
    }
}
