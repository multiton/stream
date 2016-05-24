using Microsoft.EntityFrameworkCore;

using Stream.Domain.Entity.Product;

namespace Stream.DAL.EntityFramework
{
    public class CoreDataContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=huron;Database=Stream;User=sa;Password=stalker45");
        }
    }
}