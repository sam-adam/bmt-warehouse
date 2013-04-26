namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Position);
            Map(x => x.Address);
            Map(x => x.Phone);
            Map(x => x.Cellphone);
            Map(x => x.Email);
            Map(x => x.Branch);
            Map(x => x.JoinDate);
            Map(x => x.Status);
            Map(x => x.BirthDate);
        }
    }
}
