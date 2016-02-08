namespace Stream.Domain.Entity.Facade
{
    public interface INewId<TId> where TId : struct
    {
        TId GetNewId<TEntity>(TEntity entity) where TEntity : BaseEntity<TId>;

        TId GetNewId();
    }
}