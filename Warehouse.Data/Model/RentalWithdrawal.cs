namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class RentalWithdrawal : Entity
    {
        public virtual string Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime WithdrawalDate { get; set; }
        public virtual string Reference { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<RentalWithdrawalDetail> Details { get; protected set; }

        public virtual void AddDetail(RentalWithdrawalDetail rentalWithdrawalDetail)
        {
            if (Details == null)
            {
                Details = new List<RentalWithdrawalDetail>();
            }

            Details.Add(rentalWithdrawalDetail);
        }
    }
}
