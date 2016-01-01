using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Stream.DAL.Facade
{
    public interface IEntityCollection<TEntity> where TEntity : class, new()
    {
        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Update(TEntity entity);

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
    }
}