namespace Warehouse.Business.Model
{
    using Warehouse.Data.Model;

    public class MutationIn : Mutation
    {
        public RentalReceipt RentalReceipt { get; set; }

        public override MutationType MutationType
        {
            get { return MutationType.In; }
        }
    }
}
