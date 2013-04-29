namespace Warehouse.Data.Model
{
    public class RentalProduct : Entity
    {
        public virtual string Id { get; set; }
        public virtual string Description { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductSubcategory ProductSubcategory { get; set; }
        public virtual string Brand { get; set; }
    }
}
