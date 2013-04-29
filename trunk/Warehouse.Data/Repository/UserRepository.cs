namespace Warehouse.Data.Repository
{
    using NHibernate;
    using System.Linq;
    using System.Collections.Generic;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ISession session) : base(session)
        {
        }

        public IEnumerable<User> GetAllAsEnumerable()
        {
            return GetAll().AsEnumerable();
        }
    }
}
