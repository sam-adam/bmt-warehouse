namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalWithdrawalDetailMap : ClassMap<RentalWithdrawalDetail>
    {
        public RentalWithdrawalDetailMap()
        {
            Table("tbl_detailrentalwithdrawal");

            CompositeId()
                .KeyReference(x => x.RentalWithdrawal, "id_rentalwithdrawal")
                .KeyReference(x => x.ProductCategory, "id_category")
                .KeyReference(x => x.ProductSubcategory, "id_subcategory");
            Map(x => x.Brand);
            Map(x => x.Description);
            Map(x => x.Quantity);
        }
    }
}
