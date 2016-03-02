using System;
using System.Collections.Generic;
using System.Core.Services.Facade;

using Stream.DAL.Facade;
using Stream.Domain.Entity.Product;
using Stream.Repository.Facade;
using Stream.Repository.Facade.Product;

namespace Stream.Core.Services.Product
{
    public class CategoryService : BaseDataService
    {
        private readonly KeyedByTypeCollection<object> repositoryCollection;

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

            repositoryCollection = new KeyedByTypeCollection<object>
            {
                cateroryRepository, productRepository
            };
        }

        public Category AddCategory(Category category)
        {
            var newCategory = this.cateroryRepository.Add(category);
            this.UnitOfWork.SaveChanges();

            return newCategory;
        }

        public Item AddProduct(Item item)
        {
            var newProduct = this.productRepository.Add(item);
            this.UnitOfWork.SaveChanges();

            return newProduct;
        }

        public TEntity AddEntity<TEntity>(TEntity newEntity) where TEntity: class
        {
            var repository = (ICreatable<TEntity>) repositoryCollection.Find<TEntity>();
            var savedEntity = repository.Add(newEntity);
            this.UnitOfWork.SaveChanges();

            return savedEntity;
        }
    }
}

