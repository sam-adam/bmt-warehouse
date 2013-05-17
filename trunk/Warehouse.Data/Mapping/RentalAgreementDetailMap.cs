namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalAgreementDetailMap : ClassMap<RentalAgreementDetail>
    {
        public RentalAgreementDetailMap()
        {
            Table("tbl_detailrentalagreement");

            CompositeId()
                .KeyReference(x => x.RentalAgreement, "id_rentalagreement")
                .KeyReference(x => x.Category, "id_category")
                .KeyReference(x => x.Subcategory, "id_subcategory");
            Map(x => x.Price);
        }
    }
}
