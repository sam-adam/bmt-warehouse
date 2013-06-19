namespace Warehouse.Data.Model
{
    using System.ComponentModel;

    public class RentalAgreementDetail : Entity
    {
        [Browsable(false)]
        public virtual RentalAgreement RentalAgreement { get; set; }

        [DisplayName("Category")]
        public virtual ProductCategory Category { get; set; }

        [DisplayName("Subcategory")]
        public virtual ProductSubcategory Subcategory { get; set; }
        public virtual double Price { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as RentalAgreementDetail;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return RentalAgreement == other.RentalAgreement
                   && Category == other.Category
                   && Subcategory == other.Subcategory;
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