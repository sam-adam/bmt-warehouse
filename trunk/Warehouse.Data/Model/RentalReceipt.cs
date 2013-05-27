﻿namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class RentalReceipt : Entity
    {
        public virtual string Id { get; set; }
        public virtual RentalAgreement RentalAgreement { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ReceiptDate { get; set; }
        public virtual string Reference { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<RentalReceiptDetail> Details { get; protected set; }

        public virtual void AddDetail(RentalReceiptDetail rentalReceiptDetail)
        {
            if (Details == null)
            {
                Details = new List<RentalReceiptDetail>();
            }

            Details.Add(rentalReceiptDetail);
        }
    }
}
