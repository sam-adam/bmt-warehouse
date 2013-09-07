namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class InvoiceMonthlyMap : ClassMap<InvoiceMonthly>
    {
        public InvoiceMonthlyMap()
        {
            Table("tbl_trinvoicemonthly");

            Id(x => x.Id, "id_invoicemonthly");
            References(x => x.RentalAgreement, "id_rentalagreement");
            Map(x => x.Discount);
            Map(x => x.DiscountRemark, "discount_remark");
            Map(x => x.Period);
            Map(x => x.InvoiceDate, "invoice_date");
            Map(x => x.CreatedDate, "created_date");
            References(x => x.CreatedBy, "created_by");
            HasMany(x => x.Details)
                .KeyColumn("id_invoicemonthly")
                .Cascade.All()
                .Inverse();
        }
    }
}
