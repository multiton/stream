using  System;
using Microsoft.Data.Entity;

using Stream.Domain.Entity.Facade;
using Stream.Domain.Entity.Product;

namespace Stream.Repository.Product
{
    public class CategoryRepository : EntityFrameworkGenericRepository<Guid, Category, GuidIdInitializer<Category>>
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {            
        }
    }
}