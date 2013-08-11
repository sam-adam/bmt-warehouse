namespace Warehouse.Data.Model
{
    public class RentalProductAdjusmentDetail : Entity
    {
        public virtual RentalProductAdjustment RentalProductAdjusment { get; set; }
        public virtual RentalProduct RentalProduct { get; set; }
        public virtual int PreviousStock { get; set; }
        public virtual int AdjustedStock { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as RentalProductAdjusmentDetail;

            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(other, this)) return true;

            return RentalProductAdjusment == other.RentalProductAdjusment
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
