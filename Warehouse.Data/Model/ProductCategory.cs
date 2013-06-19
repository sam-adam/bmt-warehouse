namespace Warehouse.Data.Model
{
    public class ProductCategory
    {
        public virtual string Id { get; set; }
        public virtual string Category { get; set; }

        public override string ToString()
        {
            return Category;
        }
    }
}