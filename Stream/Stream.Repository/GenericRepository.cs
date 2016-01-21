using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Stream.DAL.Facade;
using Stream.Domain.Entity.Facade;
using Stream.Repository.Facade;

namespace Stream.Repository
{
    public abstract class GenericRepository<TId, TEntity, TIdInitializer> :
        IModifiable<TEntity>,
        ICreatable<TEntity>,
        IFindable<TEntity>
        where TId : struct
        where TEntity : BaseEntity<TId>
        where TIdInitializer : INewId<TId>, new()
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IEntityCollection<TEntity, TId> entities;

        protected GenericRepository(IUnitOfWork unitOfWork, IEntityCollection<TEntity, TId> entities)
        {
            this.unitOfWork = unitOfWork;
            this.entities = entities;
        }

        public TEntity Add(TEntity entity)
        {
            entity.Id = new TIdInitializer().GetNewId(entity.Id);
            this.entities.Add(entity);

            return entity;
        }

        public TEntity Get(TId id)
        {
            return entities.Where(x => x.Id.Equals(id)).SingleOrDefault();
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

        public bool Remove(TEntity entity)
        {
            return this.entities.Remove(entity);
        }

        public void SaveChanges()
        {
            this.unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.unitOfWork.Dispose();                
            }
        }

        ~GenericRepository()
        {
            Dispose(false);
        }
    }
}