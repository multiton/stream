using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;

namespace Stream.DAL.Facade
{
    public interface IEntityCollection<TEntity> :
        IOrderedQueryable<TEntity>,
        IQueryable<TEntity>,
        IEnumerable<TEntity>,
        IEnumerable,
        IQueryable,
        IOrderedQueryable,
        // IAsyncEnumerableAccessor<TEntity>,
        // IInfrastructure<IServiceProvider>,
        IListSource
        where TEntity : class
    {
    }
}