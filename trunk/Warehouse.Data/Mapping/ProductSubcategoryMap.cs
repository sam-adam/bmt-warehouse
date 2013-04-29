namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class ProductSubcategoryMap : ClassMap<ProductSubcategory>
    {
        public ProductSubcategoryMap()
        {
            Table("tbl_msproductsubcategory");

            Id(x => x.Id, "id_subcategory");
            References(x => x.Category, "id_category");
            Map(x => x.Subcategory);
        }
    }
}
