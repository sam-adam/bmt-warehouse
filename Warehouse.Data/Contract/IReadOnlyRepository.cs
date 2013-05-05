using System.Collections.Generic;

namespace Warehouse.Data.Contract
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IReadOnlyRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);
        IQueryable<T> Filter(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 50);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    }
}
