namespace Warehouse.Data.Model
{
    public class RentalReceiptLoadingDetail : Entity
    {
        public virtual RentalReceipt RentalReceipt { get; set; }
        public virtual string Description { get; set; }
        public virtual double Price { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = GetType().GetHashCode();

                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as RentalReceiptLoadingDetail;

            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(other, this)) return true;

            return other.RentalReceipt == RentalReceipt;
        }
    }
}
