namespace Warehouse.Data.Model
{
    using System;

    public class Employee : Entity
    {
        public virtual string Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Position { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Cellphone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Branch { get; set; }
        public virtual DateTime JoinDate { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime BirthDate { get; set; }
    }
}
