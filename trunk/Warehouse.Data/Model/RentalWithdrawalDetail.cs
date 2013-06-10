namespace Warehouse.Data.Model
{
    public class RentalWithdrawalDetail : Entity
    {
        public virtual RentalWithdrawal RentalWithdrawal { get; set; }
        public virtual RentalProduct RentalProduct { get; set; }
        public virtual int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as RentalWithdrawalDetail;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return RentalWithdrawal == other.RentalWithdrawal
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
