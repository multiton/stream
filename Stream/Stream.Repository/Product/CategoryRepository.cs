using Stream.DAL.Facade;
using Stream.Domain.Entity.Product;
using Stream.Repository.Facade.Product;

namespace Stream.Repository.Product
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {            
        }
    }
}