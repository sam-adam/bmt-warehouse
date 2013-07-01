namespace Warehouse.Presentation.Contract
{
    public interface ILoginForm
    {
        string UsernameInput { get; }
        string PasswordInput { get; }
        bool LoggedIn { get; set; }

        void ShowMessage(string message);
    }
}