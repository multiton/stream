using System;
using System.Linq;

namespace Stream.DAL.Facade
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();

        IEntityCollection<TEntity> GetDbSet<TEntity>() where TEntity : class;

        // To Do: Pending (re-consider later)
        // Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}