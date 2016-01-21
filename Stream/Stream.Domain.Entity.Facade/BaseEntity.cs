namespace Stream.Domain.Entity.Facade
{
    public abstract class BaseEntity<TId> : IIdentifiable<TId> where TId : struct
    {
        public TId Id { get; set; }
    }
}