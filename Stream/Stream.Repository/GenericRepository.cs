using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Stream.DAL.Facade;
using Stream.Repository.Facade;

namespace Stream.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity: class, new()
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IEntityCollection<TEntity> entities;

        protected GenericRepository(IUnitOfWork unitOfWork, IEntityCollection<TEntity> entities)
        {
            this.unitOfWork = unitOfWork;
            this.entities = entities;
        }

        public void Insert(TEntity entity)
        {
            this.entities.Add(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public void Update(TEntity entity)
        {
            this.entities.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            this.entities.Remove(entity);
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