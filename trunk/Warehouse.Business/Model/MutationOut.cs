namespace Warehouse.Business.Model
{
    using Warehouse.Data.Model;

    public class MutationOut : Mutation
    {
        public RentalWithdrawal RentalWithdrawal { get; set; }
        public override MutationType MutationType
        {
            get { return MutationType.Out; }
        }
    }
}
