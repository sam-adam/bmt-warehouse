namespace Warehouse.Data.Model
{
    using Warehouse.Helper;

    public class RentalWithdrawalUnloadingDetail
    {
        public virtual RentalWithdrawal RentalWithdrawal { get; set; }
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
            var other = obj as RentalWithdrawalUnloadingDetail;

            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(other, this)) return true;

            return other.RentalWithdrawal == RentalWithdrawal
                && other.Description == Description
                && MathHelper.IsAboutEqual(other.Price, Price);
        }
    }
}
