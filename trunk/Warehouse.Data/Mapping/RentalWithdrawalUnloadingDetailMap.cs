namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalWithdrawalUnloadingDetailMap : ClassMap<RentalWithdrawalUnloadingDetail>
    {
        public RentalWithdrawalUnloadingDetailMap()
        {
            Table("tbl_detailrentalwithdrawalunloading");

            CompositeId()
                .KeyReference(x => x.RentalWithdrawal, "id_rentalwithdrawal")
                .KeyProperty(x => x.Description);
            Map(x => x.Price);
        }
    }
}
