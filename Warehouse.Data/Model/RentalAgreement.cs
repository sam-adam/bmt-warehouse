namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class RentalAgreement : Entity
    {
        public virtual string Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime AgreementDate { get; set; }
        public virtual int CutOffDate { get; set; }
        public virtual string Reference { get; set; }
        public virtual string Sender { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<RentalAgreementDetail> Details { get; protected set; }

        public virtual void AddRentalDetails(RentalAgreementDetail rentalAgreementDetail)
        {
            if (Details == null)
            {
                Details = new List<RentalAgreementDetail>();
            }

            Details.Add(rentalAgreementDetail);
        }
    }
}
