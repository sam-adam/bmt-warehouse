namespace Warehouse.Data.Model
{
    public class User : Entity
    {
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
