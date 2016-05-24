namespace Stream.Repository.Facade
{
    public interface IRemovable<TEntity> where TEntity : class
    {
        TEntity Remove(TEntity entity);
    }
}