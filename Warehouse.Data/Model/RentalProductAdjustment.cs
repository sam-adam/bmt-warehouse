namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class RentalProductAdjustment : Entity
    {
        public virtual string Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual IList<RentalProductAdjusmentDetail> Details { get; set; }
    }
}
