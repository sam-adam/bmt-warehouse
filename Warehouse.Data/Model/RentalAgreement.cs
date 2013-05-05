namespace Warehouse.Data.Model
{
    using System.Collections.Generic;

    public class RentalAgreement : Entity
    {
        private readonly IList<RentalAgreementDetail> _details = new List<RentalAgreementDetail>(); 

        public virtual string Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual string CreatedDate { get; set; }
        public virtual string AgreementDate { get; set; }
        public virtual string Reference { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<RentalAgreementDetail> Details { get { return _details; } }

        public virtual void AddRentalAgreementDetail(RentalAgreementDetail rentalAgreementDetail)
        {
            _details.Add(rentalAgreementDetail);
        }
    }
}
