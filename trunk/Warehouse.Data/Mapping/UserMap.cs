namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("tbl_msuser");

            Id(x => x.Username);
            Map(x => x.Password);
            References(x => x.Employee, "id_employee");
        }
    }
}
