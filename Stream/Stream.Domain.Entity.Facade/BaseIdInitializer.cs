using System;

namespace Stream.Domain.Entity.Facade
{
    public abstract class BaseIdInitializer<TId> : INewId<TId>
    {
        private readonly Func<TId> emptyValue;
        private readonly Func<TId> newValue;

        protected BaseIdInitializer(Func<TId> emptyValue, Func<TId> newValue)
        {
            this.emptyValue = emptyValue;
            this.newValue = newValue;
        }

        public TId GetNewId(TId id)
        {
            if (id.Equals(this.emptyValue()))
            {
                id = this.newValue();
            }

            return id;
        }

        public TId GetNewId()
        {
            return this.newValue();
        }
    }
}