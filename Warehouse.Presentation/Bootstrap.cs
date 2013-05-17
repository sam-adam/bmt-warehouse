namespace Warehouse.Presentation
{
    using Autofac;
    using Warehouse.Business;
    using Warehouse.Data;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Repository;
    using Warehouse.Presentation.View;

    public class Bootstrap
    {
        public IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Bootstrap>().AsSelf();
            
            builder.RegisterType<Common>().SingleInstance();
            builder.RegisterType<Bootstrap>().AsSelf().SingleInstance();

            builder.RegisterType<SessionFactory>();
            builder.Register(c => c.Resolve<SessionFactory>().OpenSession()).SingleInstance();
            builder.RegisterType<SystemSetting>().As<ISystemSetting>();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<ProductCategoryRepository>().As<IProductCategoryRepository>();
            builder.RegisterType<ProductSubcategoryRepository>().As<IProductSubcategoryRepository>();
            builder.RegisterType<RentalAgreementRepository>().As<IRentalAgreementRepository>();
            builder.RegisterType<RentalReceiptRepository>().As<IRentalReceiptRepository>();

            builder.RegisterType<LoginBl>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementBl>().InstancePerDependency();
            builder.RegisterType<RentalReceiptBl>().InstancePerDependency();
            builder.RegisterType<CustomerBl>().InstancePerDependency();

            builder.RegisterType<LoginFrm>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementFrm>();
            builder.RegisterType<RentalReceiptFrm>();

            builder.RegisterType<CustomerView>().InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
