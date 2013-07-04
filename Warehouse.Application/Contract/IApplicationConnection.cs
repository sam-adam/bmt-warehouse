namespace Warehouse.Application.Contract
{
    public interface IApplicationConnection
    {
        string Server { get; set; }
        string Database { get; set; }
        string UserId { get; set; }
        string Password { get; set; }
        string AllowZeroDatetime { get; }
        string ConvertZeroDatetime { get; }
    }
}
