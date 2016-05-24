using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Stream.Domain.Entity.Facade;
using Stream.Repository.Facade;

namespace Stream.Repository
{
    public class EntityFrameworkRepository<TId, TEntity, TIdInitializer> :
        ICreatable<TEntity>,
        IRetrievable<TId, TEntity>,
        IModifiable<TEntity>,
        IRemovable<TEntity>
        where TId : struct
        where TEntity : BaseEntity<TId>
        where TIdInitializer : INewId<TId>, new()
    {
        private readonly DbContext dbContext;
        private readonly DbSet<TEntity> entitySet;

        public EntityFrameworkRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            entity.Id = new TIdInitializer().GetNewId(entity);
            this.entitySet.Add(entity);

            return entity;
        }

        public TEntity Get(TId id)
        {
            return entitySet.SingleOrDefault(x => x.Id.Equals(id));
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return entitySet.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> Find(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy,
            int startFrom, int pageSize)
        {
            IQueryable<TEntity> query = this.entitySet.AsNoTracking();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (pageSize != 0)
            {
                query = query.Skip(startFrom).Take(pageSize);
            }

            return query;
        }

        public TEntity Save(TEntity entity)
        {
            this.entitySet.Update(entity);
            return entity;
        }

        public TEntity Remove(TEntity entity)
        {
            this.entitySet.Remove(entity);
            return entity;                
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}