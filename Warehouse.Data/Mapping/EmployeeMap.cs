namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("tbl_msemployee");

            Id(x => x.Id, "id_employee");
            Map(x => x.Name);
            Map(x => x.Position);
            Map(x => x.Address);
            Map(x => x.Phone);
            Map(x => x.Cellphone);
            Map(x => x.Email);
            Map(x => x.Branch, "id_branch");
            Map(x => x.JoinDate, "join_date");
            Map(x => x.Status);
            Map(x => x.BirthDate);
        }
    }
}
