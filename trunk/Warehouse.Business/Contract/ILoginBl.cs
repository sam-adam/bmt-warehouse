namespace Warehouse.Business.Contract
{
    using Warehouse.Data.Model;

    public interface ILoginBl : IUserBl
    {
        bool DoLogin(User user);
    }
}
