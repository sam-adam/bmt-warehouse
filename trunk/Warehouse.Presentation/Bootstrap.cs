namespace Warehouse.Presentation
{
    using Autofac;
    using CrystalDecisions.CrystalReports.Engine;
    using Warehouse.Business;
    using Warehouse.Business.Contract;
    using Warehouse.Business.Facade;
    using Warehouse.Data;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Repository;
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

            builder.RegisterType<Bootstrap>().AsSelf();
            
            builder.RegisterType<Common>().SingleInstance();
            builder.RegisterType<Bootstrap>().AsSelf().SingleInstance();

            builder.RegisterType<SessionFactory>();
            builder.Register(c => c.Resolve<SessionFactory>().OpenSession()).SingleInstance();
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
            builder.RegisterType<LoginFrm>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementFrm>().InstancePerLifetimeScope();
            builder.RegisterType<RentalReceiptFrm>().InstancePerLifetimeScope();
            builder.RegisterType<RentalWithdrawalFrm>().InstancePerLifetimeScope();
            builder.RegisterType<InvoiceMonthlyFrm>().InstancePerLifetimeScope();
            builder.RegisterType<InvoiceWithdrawalFrm>().InstancePerLifetimeScope();

            builder.RegisterType<CustomerView>().InstancePerLifetimeScope();
            builder.RegisterType<ProductSubcategoryView>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementView>().InstancePerLifetimeScope();
            builder.RegisterType<RentalAgreementDetailView>().InstancePerLifetimeScope();

            builder.RegisterType<ReportDocument>();

            builder.RegisterType<RentalAgreementRpt>();
            builder.RegisterType<RentalReceiptRpt>();
            builder.RegisterType<RentalWithdrawalRpt>();
            builder.RegisterType<InvoiceWithdrawalRpt>();
            builder.RegisterType<InvoiceMonthlyRpt>();

            return builder.Build();
        }
    }
}
