using System;

namespace Stream.Domain.Entity.Facade
{
    public abstract class BaseIdInitializer<TId> : INewId<TId> where TId : struct
    {
        private readonly Func<TId> emptyValue;
        private readonly Func<TId> newValue;

        protected BaseIdInitializer(Func<TId> emptyValue, Func<TId> newValue)
        {
            this.emptyValue = emptyValue;
            this.newValue = newValue;
        }

        public TId GetNewId<TEntity>(TEntity entity) where TEntity : BaseEntity<TId>
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