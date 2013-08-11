namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalProductMap : ClassMap<RentalProduct>
    {
        public RentalProductMap()
        {
            Table("tbl_msrentalproduct");

            Id(x => x.Id, "id_rentalproduct");
            References(x => x.Customer, "id_customer");
            Map(x => x.Description);
            References(x => x.ProductCategory, "id_category");
            References(x => x.ProductSubcategory, "id_subcategory");
            Map(x => x.Brand);
            Map(x => x.Stock);
            Map(x => x.CreatedDate, "created_date");
            References(x => x.CreatedBy, "created_by")
                .Not.LazyLoad();
        }
    }
}
