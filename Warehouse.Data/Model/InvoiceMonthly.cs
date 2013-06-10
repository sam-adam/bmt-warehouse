namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class InvoiceMonthly : Entity
    {
        public virtual string Id { get; set; }
        public virtual RentalAgreement RentalAgreement { get; set; }
        public virtual double Discount { get; set; }
        public virtual string DiscountRemark { get; set; }
        public virtual DateTime InvoiceDate { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual IList<InvoiceMonthlyDetail> Details { get; protected set; }

        public virtual void AddDetail(InvoiceMonthlyDetail detail)
        {
            if (Details == null)
            {
                Details = new List<InvoiceMonthlyDetail>();
            }

            Details.Add(detail);
        }
    }
}
