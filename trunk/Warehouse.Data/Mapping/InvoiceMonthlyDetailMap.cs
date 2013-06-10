namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class InvoiceMonthlyDetailMap : ClassMap<InvoiceMonthlyDetail>
    {
        public InvoiceMonthlyDetailMap()
        {
            Table("tbl_detailinvoicemonthly");

            CompositeId()
                .KeyReference(x => x.InvoiceMonthly, "id_invoicemonthly")
                .KeyReference(x => x.RentalProduct, "id_rentalproduct");
            Map(x => x.Quantity);
            Map(x => x.Price);
        }
    }
}
