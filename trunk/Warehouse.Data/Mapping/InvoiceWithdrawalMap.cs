namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class InvoiceWithdrawalMap : ClassMap<InvoiceWithdrawal>
    {
        public InvoiceWithdrawalMap()
        {
            Table("tbl_trinvoicewithdrawal");

            Id(x => x.Id, "id_invoicewithdrawal");
            References(x => x.RentalWithdrawal, "id_rentalwithdrawal");
            References(x => x.RentalAgreement, "id_rentalagreement");
            Map(x => x.InvoiceDate, "invoice_date");
            Map(x => x.CreatedDate, "created_date");
            References(x => x.CreatedBy, "created_by");
            HasMany(x => x.Details)
                .KeyColumn("id_invoicewithdrawal")
                .Cascade.All()
                .Inverse();
        }
    }
}
