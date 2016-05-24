using System;
using Microsoft.EntityFrameworkCore;

using Stream.Domain.Entity.Facade;
using Stream.Domain.Entity.Product;
using Stream.Repository.Facade.Product;

namespace Stream.Repository.Product
{
    public class CategoryRepository : EntityFrameworkRepository<Guid, Category, GuidIdInitializer>, ICategoryRepository<Category, Guid>
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Category GetChildNodes(Category parentNode)
        {
            // dbContext.Set<Category>().Where(c => c.ParentId == parentNode.Id);

            return new Category();
        }
    }
}