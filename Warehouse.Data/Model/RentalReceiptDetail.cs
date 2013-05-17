namespace Warehouse.Data.Model
{
    public class RentalReceiptDetail
    {
        public virtual RentalReceipt RentalReceipt { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductSubcategory ProductSubcategory { get; set; }
        public virtual string Brand { get; set; }
        public virtual string Description { get; set; }
        public virtual int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as RentalReceiptDetail;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return RentalReceipt == other.RentalReceipt
                   && ProductCategory == other.ProductCategory
                   && ProductSubcategory == other.ProductSubcategory;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = GetType().GetHashCode();

                return hash;
            }
        }
    }
}
