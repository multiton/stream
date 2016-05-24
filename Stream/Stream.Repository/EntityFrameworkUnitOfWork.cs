using Microsoft.EntityFrameworkCore;
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

        public IEntityCollection<TEntity> GetDbSet<TEntity>() where TEntity : class
        {
            return dbContext.Set<TEntity>() as IEntityCollection<TEntity>;
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