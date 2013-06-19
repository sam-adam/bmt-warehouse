namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalWithdrawalUnloadingDetailMap : ClassMap<RentalWithdrawalUnloadingDetail>
    {
        public RentalWithdrawalUnloadingDetailMap()
        {
            CompositeId()
                .KeyReference(x => x.RentalWithdrawal, "id_rentalwithdrawal");
            Map(x => x.Description);
            Map(x => x.Price);
        }
    }
}
