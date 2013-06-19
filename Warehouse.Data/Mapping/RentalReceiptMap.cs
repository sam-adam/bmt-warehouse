﻿namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalReceiptMap : ClassMap<RentalReceipt>
    {
        public RentalReceiptMap()
        {
            Table("tbl_trrentalreceipt");

            Id(x => x.Id, "id_rentalreceipt");
            References(x => x.RentalAgreement, "id_rentalagreement");
            Map(x => x.CreatedDate, "created_date");
            Map(x => x.ReceiptDate, "receipt_date");
            Map(x => x.Sender);
            Map(x => x.Reference);
            References(x => x.CreatedBy, "created_by");
            Map(x => x.Status);
            HasMany(x => x.Details)
                .KeyColumn("id_rentalreceipt")
                .Inverse()
                .Cascade.All();
            HasMany(x => x.LoadingDetails)
                .KeyColumn("id_rentalreceipt")
                .Inverse()
                .Cascade.All();
        }
    }
}
