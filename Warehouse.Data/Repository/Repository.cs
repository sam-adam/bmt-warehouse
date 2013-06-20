namespace Warehouse.Data.Repository
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using NHibernate;
    using NHibernate.Linq;
    using Warehouse.Data.Contract;

    public abstract class Repository<T> : IDisposable, IRepository<T> where T : class
    {
        private readonly ISession _session;
        private ITransaction _transaction;
        private bool _disposed = false;

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

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        #endregion

        #region IRepository<T> members

        public void Add(T t)
        {
            _transaction = _session.BeginTransaction();

            _session.Save(t);

            _transaction.Commit();
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
            _transaction = _session.BeginTransaction();

            _session.Update(t);

            _transaction.Commit();
        }
        #endregion

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _session.Dispose();
                }

                _disposed = true;
            }
        }

        ~Repository()
        {
            Dispose(false);
        }
    }
}