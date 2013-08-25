namespace Warehouse.Data.Contract
{
    using NHibernate;
    using System;
    using System.Linq.Expressions;

    public interface IRepository<T> : IReadOnlyRepository<T> where T : class
    {
        void Add(T t);
        void Delete(T t);
        void Delete(Expression<Func<T, bool>> predicate);
        void Update(T t);
    }
}
