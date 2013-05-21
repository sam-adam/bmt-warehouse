namespace Warehouse.Business.Contract
{
    public interface IBusinessLogic <T> where T:class
    {
        string GenerateNewId();
        string Save(T t);
        string Update(T t);
        void Validate(T t);
    }
}
