namespace Warehouse.Data.Model
{
    using System.Collections.Generic;
    using System.Linq;

    public class Customer : Entity
    {
        public virtual string Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string Address3 { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string JoinDate { get; set; }
        public virtual string Status { get; set; }
        public virtual string ContactPerson { get; set; }
        public virtual string TaxId { get; set; }
        public virtual double CreditLimit { get; set; }
        protected internal virtual IList<RentalAgreement> RentalAgreements { get; protected set; }

        public virtual RentalAgreement GetActiveRental()
        {
            return RentalAgreements.FirstOrDefault(rental => rental.Status == "ACTIVE");
        }

        public virtual bool HasRentalAgreement()
        {
            return RentalAgreements.Count > 0;
        }
    }
}
