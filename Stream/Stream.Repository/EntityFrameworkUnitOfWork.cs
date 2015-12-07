using Microsoft.Data.Entity;
using Stream.DAL.Facade;

namespace Stream.Repository
{
    internal class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        protected EntityFrameworkUnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        internal DbSet<T> GetDbSet<T>() where T : class
        {
            return dbContext.Set<T>();
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}