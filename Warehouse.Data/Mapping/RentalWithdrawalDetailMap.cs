﻿namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class RentalWithdrawalDetailMap : ClassMap<RentalWithdrawalDetail>
    {
        public RentalWithdrawalDetailMap()
        {
            Table("tbl_detailrentalwithdrawal");

            CompositeId()
                .KeyReference(x => x.RentalWithdrawal, "id_rentalwithdrawal")
                .KeyReference(x => x.RentalProduct, "id_rentalproduct");
            Map(x => x.Quantity);
        }
    }
}
