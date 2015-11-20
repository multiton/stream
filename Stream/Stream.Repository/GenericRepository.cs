using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Stream.Repository.Facade;

namespace Stream.Repository
{
    public abstract class GenericRepository<TEntity, TKey>
        : IGenericRepository<TEntity, TKey> where TEntity: class, new()
    {
        public void Insert(TEntity entity)
        {
            //
        }

        public TEntity Get(TKey id)
        {
            return new TEntity();
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return new List<TEntity>();
        }

        public void Update(TEntity entity)
        {
            //
        }

        public void Delete(TKey id)
        {
            //
        }

        public void SaveChanges()
        {
            //
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~GenericRepository() 
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //if (dbContext != null)
                //{
                //    dbContext.Dispose();
                //    dbContext = null;
                //}
            }
        }
    }
}