using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Stream.Domain.Entity.Facade;

namespace Stream.DAL.Facade
{
    public interface IEntityCollection<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        void Add(TEntity entity);

        bool Remove(TEntity entity);

        void Update(TEntity entity);

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
    }
}