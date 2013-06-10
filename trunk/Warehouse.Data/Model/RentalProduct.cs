namespace Warehouse.Data.Model
{
    using System;

    public class RentalProduct : Entity
    {
        public virtual string Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual string Description { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductSubcategory ProductSubcategory { get; set; }
        public virtual string Brand { get; set; }
        public virtual int Stock { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual Employee CreatedBy { get; set; }
    }
}
