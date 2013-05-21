namespace Warehouse.Business.Contract
{
    using Warehouse.Data.Model;

    public interface IUserBl
    {
        void SetLoggedInUser(User user);
    }
}
