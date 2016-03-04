using System;
using System.Collections.Generic;
using System.Core.Services.Facade;
using System.Linq.Expressions;

using Stream.DAL.Facade;
using Stream.Domain.Entity.Facade;
using Stream.Repository;

namespace Stream.Core.Services
{
    public class DataService<TId, TEntity, TIdInitializer> : BaseDataService
        where TId : struct
        where TEntity : BaseEntity<TId>
        where TIdInitializer : INewId<TId>, new()
    {
        private readonly EntityFrameworkRepository<TId, TEntity, TIdInitializer> repository;

        protected DataService(
            IUnitOfWork unitOfWork,
            EntityFrameworkRepository<TId, TEntity, TIdInitializer> repository) : base(unitOfWork)
        {
            this.repository = repository;
        }

        public TEntity Add(TEntity entity)
        {
            var newEntity = this.repository.Add(entity);
            this.UnitOfWork.SaveChanges();

            return newEntity;
        }

        public TEntity Save(TEntity entity)
        {
            var updatedEntity = this.repository.Save(entity);
            this.UnitOfWork.SaveChanges();

            return updatedEntity;
        }

        public TEntity Remove(TEntity entity)
        {
            var oldEntity = this.repository.Remove(entity);
            this.UnitOfWork.SaveChanges();

            return oldEntity;
        }

        public TEntity Get(TId entityId)
        {
            return this.repository.Get(entityId);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.repository.Find(predicate);
        }
    }
}