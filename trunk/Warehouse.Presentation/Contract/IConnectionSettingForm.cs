namespace Warehouse.Presentation.Contract
{
    public interface IConnectionSettingForm
    {
        string Server { get; set; }
        string Database { get; set; }
        string UserId { get; set; }
        string Password { get; set; }
    }
}