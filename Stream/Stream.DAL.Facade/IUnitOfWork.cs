using System;
using System.Linq;

namespace Stream.DAL.Facade
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();

        IOrderedQueryable<TEntity> GetDbSet<TEntity>() where TEntity : class;

        // To Do:
        // Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}