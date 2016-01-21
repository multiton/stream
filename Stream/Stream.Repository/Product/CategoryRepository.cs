using  System;

using Stream.DAL.Facade;
using Stream.Domain.Entity.Facade;
using Stream.Domain.Entity.Product;
using Stream.Repository.Facade.Product;

namespace Stream.Repository.Product
{
    public class CategoryRepository : GenericRepository<Guid, Category, GuidIdInitializer>, ICategoryRepository
    {
        public CategoryRepository(IUnitOfWork unitOfWork, IEntityCollection<Category, Guid> entities) : base(unitOfWork, entities)
        {            
        }
    }
}