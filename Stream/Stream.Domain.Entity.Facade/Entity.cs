namespace Stream.Domain.Entity.Facade
{
    public abstract class Entity<TId, TIdInitializer> : IIdentifiable<TId>
        where TId : struct
        where TIdInitializer : INewId<TId>, new()
    {
        public TId Id { get; set; }

        protected Entity()
        {
            this.Id = (new TIdInitializer()).GetNewId();
        }
    }
}