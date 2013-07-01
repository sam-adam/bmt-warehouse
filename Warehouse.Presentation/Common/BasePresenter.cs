namespace Warehouse.Presentation.Common
{
    using Warehouse.Application;

    public class BasePresenter
    {
        protected readonly EntityManager EntityManager;

        public BasePresenter(EntityManager entityManager)
        {
            EntityManager = entityManager;
        }
    }
}
