namespace Warehouse.Data.Model
{
    using Warehouse.Data.Helper;

    public class User : Entity
    {
        private string _password;

        public virtual string Username { get; set; }
        public virtual string Password
        {
            get { return _password; }
            set { _password = EncryptionService.MD5String(value); }
        }
        public virtual Employee Employee { get; set; }
    }
}
