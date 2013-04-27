using Warehouse.Business;

namespace Warehouse.Infrastructure
{
    using Autofac;
    using NHibernate;
    using Warehouse.Data;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Repository;

    public class Bootstrap
    {
        public IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserBl>();
            builder.RegisterType<SessionFactory>();
            builder.RegisterType<SystemSetting>().As<ISystemSetting>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            return builder.Build();
        }
    }
}
