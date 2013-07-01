namespace Warehouse.Business.Model
{
    public class MutationOut : Mutation
    {
        public RentalWithdrawalBl RentalWithdrawalBl { get; set; }
        public override MutationType MutationType
        {
            get { return MutationType.Out; }
        }
    }
}
