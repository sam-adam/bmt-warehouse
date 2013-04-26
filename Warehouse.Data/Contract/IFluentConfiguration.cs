using FluentNHibernate.Cfg.Db;

namespace Warehouse.Data.Contract
{
    public interface IFluentConfiguration<TConfiguration, TConnectionString> 
        where TConfiguration : PersistenceConfiguration<TConfiguration, TConnectionString> 
        where TConnectionString : ConnectionStringBuilder, new()
    {
        PersistenceConfiguration<TConfiguration, TConnectionString> Configuration { get; }
    }
}
