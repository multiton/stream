namespace Stream.Repository.Facade
{
    public interface ICreatable<TEntity> where TEntity: class
    {
        TEntity Add(TEntity entity);

        bool Remove(TEntity entity);
    }
}