namespace Warehouse.Data.Model
{
    public class InvoiceWithdrawalDetail : Entity
    {
        public virtual InvoiceWithdrawal InvoiceWithdrawal { get; set; }
        public virtual RentalProduct RentalProduct { get; set; }
        public virtual int Quantity { get; set; }
        public virtual double Price { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as InvoiceWithdrawalDetail;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return InvoiceWithdrawal == other.InvoiceWithdrawal
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
