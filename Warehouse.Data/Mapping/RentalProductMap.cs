namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalProductMap : ClassMap<RentalProduct>
    {
        public RentalProductMap()
        {
            Table("tbl_msrentalproduct");

            Id(x => x.Id);
            Map(x => x.Description);
            References(x => x.ProductCategory, "id_category");
            References(x => x.ProductSubcategory, "id_subcategory");
            Map(x => x.Brand);
        }
    }
}
