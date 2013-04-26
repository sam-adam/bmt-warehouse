using NHibernate;

namespace Warehouse.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ISession session) : base(session)
        {

        }
    }
}
