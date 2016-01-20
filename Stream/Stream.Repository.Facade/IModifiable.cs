namespace Stream.Repository.Facade
{
    public interface IModifiable<TEntity> where TEntity : class
    {
        TEntity Save(TEntity entity);
    }
}