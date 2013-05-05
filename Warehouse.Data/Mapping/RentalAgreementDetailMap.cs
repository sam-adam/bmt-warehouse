namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalAgreementDetailMap : ClassMap<RentalAgreementDetail>
    {
        public RentalAgreementDetailMap()
        {
            Table("tbl_detailrentalagreement");

            //References(x => x.RentalAgreement, "id_rentalagreement");
            //References(x => x.Category, "id_category");
            //References(x => x.Subcategory, "id_subcategory");

            CompositeId()
                .KeyReference(x => x.RentalAgreement, "id_rentalagreement")
                .KeyReference(x => x.Category, "id_category")
                .KeyReference(x => x.Subcategory, "id_subcategory");
            Map(x => x.Price);
        }
    }
}
