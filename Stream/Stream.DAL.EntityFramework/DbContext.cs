using Microsoft.Data.Entity;
using Stream.Domain.Entity.Product;

namespace Stream.DAL.EntityFramework
{
    public class DContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}