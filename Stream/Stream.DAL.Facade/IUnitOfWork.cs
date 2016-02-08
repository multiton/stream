using System;

namespace Stream.DAL.Facade
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();

        // To Do:
        // Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}