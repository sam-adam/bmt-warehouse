namespace Warehouse.Application
{
    using System.ComponentModel.DataAnnotations;
    using Warehouse.Application.Contract;
    using Warehouse.Application.Properties;

    public class ApplicationConnection : IApplicationConnection
    {
        [Required(ErrorMessage = "Server cannot be empty")]
        public string Server
        {
            get { return Settings.Default.Server; }
            set { Settings.Default.Server = value; }
        }

        [Required(ErrorMessage = "Database cannot be empty")]
        public string Database
        {
            get { return Settings.Default.Database; }
            set { Settings.Default.Database = value; }
        }

        [Required(ErrorMessage = "User Id cannot be empty")]
        public string UserId
        {
            get { return Settings.Default.UserId; }
            set { Settings.Default.UserId = value; }
        }

        [Required(ErrorMessage = "Password cannot be empty")]
        public string Password
        {
            get { return Settings.Default.Password; }
            set { Settings.Default.Password = value; }
        }

        public string AllowZeroDatetime
        {
            get { return Settings.Default.AllowZeroDatetime; }
        }

        public string ConvertZeroDatetime
        {
            get { return Settings.Default.ConvertZeroDatetime; }
        }
    }
}
