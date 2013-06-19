﻿namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalAgreementMap : ClassMap<RentalAgreement>
    {
        public RentalAgreementMap()
        {
            Table("tbl_trrentalagreement");

            Id(x => x.Id, "id_rentalagreement");
            References(x => x.Customer, "id_customer");
            Map(x => x.CreatedDate, "created_date");
            Map(x => x.AgreementDate, "agreement_date");
            Map(x => x.CutOffDate, "cut_off_date");
            Map(x => x.Reference);
            References(x => x.CreatedBy, "created_by");
            Map(x => x.Status);
            HasMany(x => x.Details)
                .KeyColumn("id_rentalagreement")
                .Inverse()
                .Cascade.All();
        }
    }
}
