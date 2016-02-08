namespace Stream.Domain.Entity.Facade
{
    public interface INewId<out TId, in TEntity>
    {
        TId GetNewId(TEntity entity);

        TId GetNewId();
    }
}