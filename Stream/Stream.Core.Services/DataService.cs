using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

using Stream.DAL.Facade;
using Stream.Core.Services.Facade;
using Stream.Repository.Facade;

namespace Stream.Core.Services
{
    public class DataService<TId, TEntity, TRepository> : BaseDataService
        where TEntity : class 
        where TRepository : ICreatable<TEntity>, IRetrievable<TId, TEntity>, IModifiable<TEntity>, IRemovable<TEntity> 
    {
        private readonly TRepository repository;

        public DataService(IUnitOfWork uow, TRepository repository) : base(uow)
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
            var savedEntity = repository.Save(entity);
            this.UnitOfWork.SaveChanges();

            return savedEntity;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return this.repository.Get(predicate);
        }

        public IEnumerable<TEntity> Find(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            return this.repository.Find(predicate, orderBy);
        }

        public TEntity Remove(TEntity entity)
        {
            var oldEntity = this.repository.Remove(entity);
            this.UnitOfWork.SaveChanges();

            return oldEntity;
        }
    }
}