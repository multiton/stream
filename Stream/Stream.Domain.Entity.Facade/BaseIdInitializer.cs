using System;

namespace Stream.Domain.Entity.Facade
{
    public abstract class BaseIdInitializer<TId, TEntity> : INewId<TId, TEntity>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        private readonly Func<TId> emptyValue;
        private readonly Func<TId> newValue;

        protected BaseIdInitializer(Func<TId> emptyValue, Func<TId> newValue)
        {
            this.emptyValue = emptyValue;
            this.newValue = newValue;
        }

        public TId GetNewId(TEntity entity)
        {
            if (entity.Id.Equals(this.emptyValue()))
            {
                return this.newValue();
            }

            return entity.Id;
        }

        public TId GetNewId()
        {
            return this.newValue();
        }
    }
}