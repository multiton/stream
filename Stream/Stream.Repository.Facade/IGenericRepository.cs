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

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void SaveChanges();
    }
}