using System;

namespace Stream.Domain.Entity.Facade
{
    public class GuidIdInitializer<TEntity> : BaseIdInitializer <Guid, TEntity>
        where TEntity : BaseEntity<Guid>
    {
        public GuidIdInitializer() : base(() => Guid.Empty, Guid.NewGuid) { }
    }
}