using System.Collections.Generic;

namespace Warehouse.Data.Repository
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using NHibernate;
    using NHibernate.Linq;
    using Warehouse.Data.Contract;

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly ISession _session ;

        protected Repository(ISession session)
        {
            if (session == null)
            {
                throw new ArgumentNullException("session");
            }

            _session = session;
        }

        #region IReadonlyRepository<T> members

        public IQueryable<T> GetAll()
        {
            return _session.Query<T>();
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 50)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate).ToList();
        }

        #endregion

        #region IRepository<T> members

        public void Add(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
