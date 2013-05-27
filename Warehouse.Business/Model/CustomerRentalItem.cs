namespace Warehouse.Business.Model
{
    using Warehouse.Data.Model;

    public class CustomerRentalItem
    {
        public ProductCategory ProductCategory { get; set; }
        public ProductSubcategory ProductSubcategory { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
