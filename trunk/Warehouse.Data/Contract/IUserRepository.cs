namespace Warehouse.Data.Contract
{
    using Model;
    using System;
    using System.Collections.Generic;

    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllAsEnumerable();
    }
}
