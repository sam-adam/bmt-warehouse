namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class InvoiceWithdrawal : Entity
    {
        public virtual string Id { get; set; }
        public virtual RentalWithdrawal RentalWithdrawal { get; set; }
        public virtual RentalAgreement RentalAgreement { get; set; }
        public virtual DateTime InvoiceDate { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual IList<InvoiceWithdrawalDetail> Details { get; protected set; }

        public virtual void AddDetail(InvoiceWithdrawalDetail detail)
        {
            if (Details == null)
            {
                Details = new List<InvoiceWithdrawalDetail>();
            }

            Details.Add(detail);
        }
    }
}
