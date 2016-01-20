namespace Stream.Domain.Entity.Facade
{
    public interface IIdentifiable<TId>
    {
        TId Id { get; set; }
    }
}