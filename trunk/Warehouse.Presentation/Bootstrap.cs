namespace Warehouse.Presentation
{
    using Autofac;
    using Warehouse.Business;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
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
            builder.RegisterType<RentalWithdrawalRepository>().As<IRentalWithdrawalRepository>();

            builder.RegisterType<LoginBl>().As<ILoginBl>();
            builder.RegisterType<RentalAgreementBl>().As<IRentalAgreementBl>();
            builder.RegisterType<RentalReceiptBl>().As<IRentalReceiptBl>();
            builder.RegisterType<RentalWithdrawalBl>().As<IRentalWithdrawalBl>();
            builder.RegisterType<CustomerBl>().As<ICustomerBl>();
            builder.RegisterType<ProductCategoryBl>().As<IProductCategoryBl>();
            builder.RegisterType<ProductSubcategoryBl>().As<IProductSubcategoryBl>();

            builder.RegisterType<RentalAgreementDetailFacade>();
            builder.RegisterType<RentalReceiptFacade>();
            builder.RegisterType<RentalWithdrawalFacade>();

            builder.RegisterType<LoginFrm>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementFrm>();
            builder.RegisterType<RentalReceiptFrm>();
            builder.RegisterType<RentalWithdrawalFrm>();

            builder.RegisterType<CustomerView>().InstancePerLifetimeScope();
            builder.RegisterType<ProductSubcategoryView>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementView>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementDetailView>().InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
