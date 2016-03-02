using Stream.Domain.Entity.Facade;

namespace Stream.Repository.Facade.Product
{
    public interface ICategoryRepository<TEntity, TId> : ICreatable<TEntity>, IModifiable<TEntity>, IFindable<TEntity>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
    }

    public interface IProductRepository<TEntity, TId> : ICreatable<TEntity>, IModifiable<TEntity>, IFindable<TEntity>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
    }
}