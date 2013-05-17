namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalReceiptMap : ClassMap<RentalReceipt>
    {
        public RentalReceiptMap()
        {
            Table("tbl_trrentalreceipt");

            Id(x => x.Id);
            References(x => x.RentalAgreement, "id_rentalagreement");
            Map(x => x.CreatedDate, "created_date");
            Map(x => x.ReceiptDate, "receipt_date");
            Map(x => x.Reference);
            References(x => x.CreatedBy, "created_by");
            HasMany(x => x.Details)
                .KeyColumn("id_rentalreceipt")
                .Inverse()
                .Cascade.All();
        }
    }
}
