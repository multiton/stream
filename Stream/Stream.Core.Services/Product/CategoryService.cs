using System;
using System.Core.Services.Facade;

using Stream.DAL.Facade;
using Stream.Domain.Entity.Product;
using Stream.Repository.Facade.Product;

namespace Stream.Core.Services.Product
{
    public class CategoryService : BaseEntityFrameworkDataService
    {
        private readonly ICategoryRepository<Category, Guid> cateroryRepository;
        private readonly IProductRepository<Item, Guid> productRepository;

        public CategoryService(
            ICategoryRepository<Category, Guid> cateroryRepository,
            IProductRepository<Item, Guid> productRepository,
            IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.cateroryRepository = cateroryRepository;
            this.productRepository = productRepository;
        }
    }
}