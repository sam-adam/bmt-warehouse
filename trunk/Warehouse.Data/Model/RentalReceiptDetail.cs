namespace Warehouse.Data.Model
{
    public class RentalReceiptDetail : Entity
    {
        public virtual RentalReceipt RentalReceipt { get; set; }
        public virtual RentalProduct RentalProduct { get; set; }
        public virtual string Remark { get; set; }
        public virtual int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as RentalReceiptDetail;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return RentalReceipt == other.RentalReceipt
                   && RentalProduct == other.RentalProduct;
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
