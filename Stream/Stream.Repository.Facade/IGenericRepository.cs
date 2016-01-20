using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Stream.Repository.Facade
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        TEntity Save(TEntity entity);

        bool Remove(TEntity entity);

        void SaveChanges();
    }
}