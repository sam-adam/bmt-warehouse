namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class ProductCategoryMap : ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            Table("tbl_msproductcategory");

            Id(x => x.Id, "id_category");
            Map(x => x.Category);
        }
    }
}
