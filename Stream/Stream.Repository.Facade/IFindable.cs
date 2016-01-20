using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Stream.Repository.Facade
{
    public interface IFindable<TEntity> where TEntity : class
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}