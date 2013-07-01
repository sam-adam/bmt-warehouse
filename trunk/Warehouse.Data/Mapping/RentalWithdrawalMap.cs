namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalWithdrawalMap : ClassMap<RentalWithdrawal>
    {
        public RentalWithdrawalMap()
        {
            Table("tbl_trrentalwithdrawal");

            Id(x => x.Id, "id_rentalwithdrawal");
            References(x => x.Customer, "id_customer");
            Map(x => x.CreatedDate, "created_date");
            Map(x => x.WithdrawalDate, "withdrawal_date");
            Map(x => x.Reference);
            References(x => x.CreatedBy, "created_by");
            Map(x => x.Status);
            HasMany(x => x.Details)
                .KeyColumn("id_rentalwithdrawal")
                .Inverse()
                .Cascade.All();
            HasMany(x => x.UnloadingDetails)
                .KeyColumn("id_rentalwithdrawal")
                .Inverse()
                .Cascade.All();
        }
    }
}
