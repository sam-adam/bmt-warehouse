namespace Warehouse.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Warehouse.Data.Model;

    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("tbl_mscustomer");

            Id(x => x.Id, "id_customer");
            Map(x => x.Title);
            Map(x => x.Name);
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.Address3);
            Map(x => x.Phone);
            Map(x => x.Email);
            Map(x => x.JoinDate, "tgl_join");
            Map(x => x.Status);
            Map(x => x.ContactPerson, "cprsn");
        }
    }
}
