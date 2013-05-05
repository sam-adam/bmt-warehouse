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
            
            builder.RegisterType<LoginBl>();
            builder.RegisterType<RentalAgreementBl>();

            builder.RegisterType<Common>().SingleInstance();

            builder.RegisterType<SessionFactory>();
            builder.Register(c => c.Resolve<SessionFactory>().OpenSession()).SingleInstance();
            builder.RegisterType<SystemSetting>().As<ISystemSetting>();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<ProductCategoryRepository>().As<IProductCategoryRepository>();
            builder.RegisterType<ProductSubcategoryRepository>().As<IProductSubcategoryRepository>();
            builder.RegisterType<RentalAgreementRepository>().As<IRentalAgreementRepository>();

            builder.RegisterType<RentalAgreementBl>().AsSelf();

            return builder.Build();
        }
    }
}
