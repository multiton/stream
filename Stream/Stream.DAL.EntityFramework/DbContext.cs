using Microsoft.Data.Entity;

using Stream.DAL.Facade;
using Stream.Domain.Entity.Product;

namespace Stream.DAL.EntityFramework
{
    public class CoreDataContext : DbContext, IUnitOfWork
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}