namespace Warehouse.Presentation
{
    using Autofac;
    using Warehouse.Application;
    using Warehouse.Application.Validator;
    using Warehouse.Business;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Data;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Repository;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Contract;
    using Warehouse.Presentation.Presenter;

    public class Bootstrap2
    {
        public IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Warehouse.Business.Common>().SingleInstance();
            builder.RegisterType<Bootstrap2>().AsSelf().SingleInstance();

            builder.RegisterType<EntityValidator>();
            builder.RegisterType<PropertyValidator>();
            builder.RegisterType<EntityManager>();

            builder.RegisterType<BasePresenter>()
                .AsSelf()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            builder.RegisterType<SessionFactory>();
            builder.Register(c => c.Resolve<SessionFactory>().OpenSession()).SingleInstance();
            builder.RegisterType<SystemSetting>().As<ISystemSetting>();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<LoginBl>().As<ILoginBl>();
            builder.RegisterType<LoginPresenter>()
                   .AsSelf();
            builder.RegisterType<LoginForm>()
                   .AsSelf()
                   .As<ILoginForm>();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<RentalAgreementRepository>().As<IRentalAgreementRepository>();
            builder.RegisterType<ProductCategoryRepository>().As<IProductCategoryRepository>();
            builder.RegisterType<ProductSubcategoryRepository>().As<IProductSubcategoryRepository>();
            builder.RegisterType<RentalAgreementBl>().As<IRentalAgreementBl>();
            builder.RegisterType<ProductCategoryBl>().As<IProductCategoryBl>();
            builder.RegisterType<ProductSubcategoryBl>().As<IProductSubcategoryBl>();
            builder.RegisterType<RentalAgreementDetailFacade>();
            builder.RegisterType<RentalAgreementPresenter>()
                   .AsSelf();
            builder.RegisterType<RentalAgreementForm>()
                   .AsSelf()
                   .As<IRentalAgreementForm>();

            return builder.Build();
        }
    }
}
