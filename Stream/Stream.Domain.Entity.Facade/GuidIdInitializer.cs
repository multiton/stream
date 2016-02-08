using System;

namespace Stream.Domain.Entity.Facade
{
    public class GuidIdInitializer : BaseIdInitializer <Guid>
    {
        public GuidIdInitializer() : base(() => Guid.Empty, Guid.NewGuid) { }
    }
}