namespace Warehouse.Data.Model
{
    using Warehouse.Helper;

    public class User : Entity
    {
        private string _password;

        public virtual string Username { get; set; }
        public virtual string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public virtual Employee Employee { get; set; }

        public virtual void EncryptPassword()
        {
            _password = EncryptionService.Md5String(_password);
        }
    }
}
