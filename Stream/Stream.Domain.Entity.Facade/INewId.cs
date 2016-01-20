namespace Stream.Domain.Entity.Facade
{
    public interface INewId<TId>
    {
        TId GetNewId(TId id);
        TId GetNewId();
    }
}