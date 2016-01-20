namespace Stream.Repository.Facade
{
    public interface IRetrievableById<in TId, out TEntity> where TEntity : class
    {
        TEntity Get(TId id);
    }
}