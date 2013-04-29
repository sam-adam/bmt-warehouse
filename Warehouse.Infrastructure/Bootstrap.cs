namespace Warehouse.Infrastructure
{
    using Autofac;
    using Warehouse.Business;
    using Warehouse.Data;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Repository;

    public class Bootstrap
    {
        public IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Bootstrap>().AsSelf();
            builder.RegisterType<UserBl>();
            builder.Register(c => c.Resolve<SessionFactory>().OpenSession());
            builder.RegisterType<SessionFactory>();
            builder.RegisterType<SystemSetting>().As<ISystemSetting>();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<RentalProductRepository>().As<IRentalProductRepository>();

            return builder.Build();
        }
    }
}
