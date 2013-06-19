namespace Warehouse.Data.Model
{
    public class ProductSubcategory : Entity
    {
        public virtual string Id { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual string Subcategory { get; set; }

        public override string ToString()
        {
            return Subcategory;
        }
    }
}