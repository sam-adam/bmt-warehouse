namespace Warehouse.Business.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IReadOnlyBusinessLogic <T> where T : class
    {
        IList<T> GetAll();
        IList<T> Get(string id);
        IList<T> Get(Expression<Func<T, bool>> predicate);
    }
}
