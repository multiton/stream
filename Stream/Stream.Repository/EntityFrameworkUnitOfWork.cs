using System.Linq;

using Microsoft.Data.Entity;
using Stream.DAL.Facade;

namespace Stream.Repository
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        public EntityFrameworkUnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IOrderedQueryable<TEntity> GetDbSet<TEntity>() where TEntity : class
        {
            return dbContext.Set<TEntity>();
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