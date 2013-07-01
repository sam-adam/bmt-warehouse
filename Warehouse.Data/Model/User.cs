namespace Warehouse.Data.Model
{
    using System.ComponentModel.DataAnnotations;
    using Warehouse.Helper;

    public class User : Entity
    {
        private string _password;

        [Required(ErrorMessage = "Username is required")]
        public virtual string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
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
