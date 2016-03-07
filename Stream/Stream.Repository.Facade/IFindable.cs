using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Stream.Repository.Facade
{
    public interface IFindable<TEntity> where TEntity : class
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Find(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
    }
}