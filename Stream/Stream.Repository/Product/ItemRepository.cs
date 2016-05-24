using System;
using Microsoft.EntityFrameworkCore;

using Stream.Domain.Entity.Facade;
using Stream.Domain.Entity.Product;

namespace Stream.Repository.Product
{
    public class ItemRepository : EntityFrameworkRepository<Guid, Item, GuidIdInitializer>
    {
        public ItemRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}