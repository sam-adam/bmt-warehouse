namespace Warehouse.Data.Model
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;

    public class RentalAgreement : Entity
    {
        public virtual string Id { get; set; }
        public virtual Customer Customer { get; set; }

        [DisplayName("Created Date")]
        public virtual DateTime CreatedDate { get; set; }

        [DisplayName("Agreement Date")]
        public virtual DateTime AgreementDate { get; set; }

        [DisplayName("Cut Off")]
        public virtual int CutOffDate { get; set; }
        public virtual string Reference { get; set; }

        [DisplayName("Admin")]
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
