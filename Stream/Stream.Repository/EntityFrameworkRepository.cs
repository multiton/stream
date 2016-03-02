using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.Data.Entity;

using Stream.Domain.Entity.Facade;
using Stream.Repository.Facade;

namespace Stream.Repository
{
    public class EntityFrameworkRepository<TId, TEntity, TIdInitializer> :
        ICreatable<TEntity>,
        IModifiable<TEntity>,
        IFindable<TEntity>
        where TId : struct
        where TEntity : BaseEntity<TId>
        where TIdInitializer : INewId<TId>, new()
    {
        private readonly DbContext dbContext;
        private readonly DbSet<TEntity> entities;

        protected EntityFrameworkRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            entity.Id = new TIdInitializer().GetNewId(entity);
            this.entities.Add(entity);

            return entity;
        }

        public TEntity Get(TId id)
        {
            return entities.SingleOrDefault(x => x.Id.Equals(id));
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public TEntity Save(TEntity entity)
        {
            this.entities.Update(entity);
            return entity;
        }

        public TEntity Remove(TEntity entity)
        {
            this.entities.Remove(entity);
            return entity;                
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}