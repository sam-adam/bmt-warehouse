namespace Warehouse.Business.Model
{
    using Warehouse.Data.Model;

    public enum MutationType { In, Out }

    public abstract class Mutation
    {
        public RentalProduct RentalProduct { get; set; }
        public int Quantity { get; set; }

        public abstract MutationType MutationType { get; }
    }
}
