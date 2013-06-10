namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class InvoiceWithdrawalDetailMap : ClassMap<InvoiceWithdrawalDetail>
    {
        public InvoiceWithdrawalDetailMap()
        {
            Table("tbl_detailinvoicewithdrawal");

            CompositeId()
                .KeyReference(x => x.InvoiceWithdrawal, "id_invoicewithdrawal")
                .KeyReference(x => x.RentalProduct, "id_rentalproduct");
            Map(x => x.Price);
            Map(x => x.Quantity);
        }
    }
}
