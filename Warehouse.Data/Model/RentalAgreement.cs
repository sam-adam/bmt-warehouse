namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class RentalAgreement : Entity
    {

        private readonly IList<RentalAgreementDetail> _details; 

        public virtual string Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime AgreementDate { get; set; }
        public virtual int CutOffDate { get; set; }
        public virtual string Reference { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<RentalAgreementDetail> Details { get { return _details; } }

        public RentalAgreement(){}

        public RentalAgreement(IList<RentalAgreementDetail> details)
        {
            _details = details;
        }
    }
}
