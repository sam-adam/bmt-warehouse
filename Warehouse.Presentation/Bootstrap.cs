namespace Warehouse.Presentation
{
    using Autofac;
    using CrystalDecisions.CrystalReports.Engine;
    using NHibernate;
    using System.ServiceProcess;
    using Warehouse.Application;
    using Warehouse.Application.Contract;
    using Warehouse.Application.Validator;
    using Warehouse.Business;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Data;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Repository;
    using Warehouse.Presentation.Common;
    using Warehouse.Presentation.Presenter;
    using Warehouse.Presentation.Print;
    using Warehouse.Presentation.View;

    /// <summary>
    /// Bootsraper class for application configuration
    /// </summary>
    public class Bootstrap
    {
        /// <summary>
        /// Configuration main function
        /// </summary>
        /// <returns>IContainer</returns>
        public IContainer Configure()
        {
            var builder = new ContainerBuilder();
            var serviceController = new ServiceController();

            serviceController.MachineName = ".";
            serviceController.ServiceName = "mysql";

            builder.RegisterType<Bootstrap>().AsSelf();
            
            builder.RegisterType<Warehouse.Business.Common>().SingleInstance();
            builder.RegisterType<Bootstrap>().AsSelf().SingleInstance();

            builder.RegisterType<SessionFactory>();
            builder.RegisterType<ApplicationManager>();
            builder.RegisterType<ApplicationConnection>().As<IApplicationConnection>();
            builder.Register(c => c.Resolve<SessionFactory>().OpenSession()).As<ISession>();
            builder.RegisterType<SystemSetting>().As<ISystemSetting>();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<RentalProductRepository>().As<IRentalProductRepository>();
            builder.RegisterType<ProductCategoryRepository>().As<IProductCategoryRepository>();
            builder.RegisterType<ProductSubcategoryRepository>().As<IProductSubcategoryRepository>();
            builder.RegisterType<RentalAgreementRepository>().As<IRentalAgreementRepository>();
            builder.RegisterType<RentalReceiptRepository>().As<IRentalReceiptRepository>();
            builder.RegisterType<RentalWithdrawalRepository>().As<IRentalWithdrawalRepository>();
            builder.RegisterType<InvoiceWithdrawalRepository>().As<IInvoiceWithdrawalRepository>();
            builder.RegisterType<InvoiceMonthlyRepository>().As<IInvoiceMonthlyRepository>();

            builder.RegisterType<LoginBl>().As<ILoginBl>();
            builder.RegisterType<RentalAgreementBl>().As<IRentalAgreementBl>();
            builder.RegisterType<RentalReceiptBl>().As<IRentalReceiptBl>();
            builder.RegisterType<RentalWithdrawalBl>().As<IRentalWithdrawalBl>();
            builder.RegisterType<CustomerBl>().As<ICustomerBl>();
            builder.RegisterType<RentalProductBl>().As<IRentalProductBl>();
            builder.RegisterType<ProductCategoryBl>().As<IProductCategoryBl>();
            builder.RegisterType<ProductSubcategoryBl>().As<IProductSubcategoryBl>();
            builder.RegisterType<InvoiceWithdrawalBl>().As<IInvoiceWithdrawalBl>();
            builder.RegisterType<InvoiceMonthlyBl>().As<IInvoiceMonthlyBl>();

            builder.RegisterType<RentalAgreementDetailFacade>();
            builder.RegisterType<RentalReceiptFacade>();
            builder.RegisterType<RentalWithdrawalFacade>();

            builder.RegisterType<Home>();
            builder.RegisterType<PrintFrm>();
            builder.RegisterType<LoginForm>();
            builder.RegisterType<RentalAgreementFrm>();
            builder.RegisterType<RentalReceiptFrm>();
            builder.RegisterType<RentalWithdrawalFrm>();
            builder.RegisterType<InvoiceMonthlyFrm>();
            builder.RegisterType<InvoiceWithdrawalFrm>();

            builder.RegisterType<CustomerView>();
            builder.RegisterType<ProductSubcategoryView>();
            builder.RegisterType<RentalAgreementView>();
            builder.RegisterType<RentalWithdrawalView>();
            builder.RegisterType<RentalReceiptView>();
            builder.RegisterType<InvoiceWithdrawalView>();
            builder.RegisterType<InvoiceMonthlyView>();
            builder.RegisterType<RentalAgreementDetailView>();
            builder.RegisterType<MutationViewForm>();

            builder.RegisterType<LoginPresenter>();
            builder.RegisterType<RentalAgreementPresenter>();
            builder.RegisterType<MutationViewPresenter>();
            builder.RegisterType<ConnectionSettingPresenter>();

            builder.RegisterType<ReportDocument>();

            builder.RegisterType<RentalAgreementRpt>();
            builder.RegisterType<RentalReceiptRpt>();
            builder.RegisterType<RentalWithdrawalRpt>();
            builder.RegisterType<InvoiceWithdrawalRpt>();
            builder.RegisterType<InvoiceMonthlyRpt>();
            builder.RegisterType<UnloadingReceiptRpt>();
            builder.RegisterType<LoadingReceiptRpt>();

            builder.RegisterType<EntityValidator>();
            builder.RegisterType<PropertyValidator>();
            builder.RegisterType<EntityManager>();

            builder.RegisterType<FormManager>();
            builder.RegisterType<BaseForm>()
                .PropertiesAutowired();

            builder.RegisterType<BasePresenter>()
                .AsSelf()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            return builder.Build();
        }
    }
}
