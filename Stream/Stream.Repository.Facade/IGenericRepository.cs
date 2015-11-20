using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Stream.Repository.Facade
{
    public interface IGenericRepository<TEntity, in TKey> : IDisposable where TEntity : class
    {
        void Insert(TEntity entity);

        TEntity Get(TKey id);

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity entity);

        void Delete(TKey id);

        void SaveChanges();
    }
}