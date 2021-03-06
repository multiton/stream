﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Stream.Repository.Facade
{
    public interface IRetrievable<in TId, TEntity> where TEntity : class
    {
        TEntity Get(TId id);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Find(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
    }
}