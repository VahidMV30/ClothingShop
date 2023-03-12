using ClothingShop.Domain.Entities;
using ClothingShop.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ClothingShop.Infrastructure
{
    public class ClothingShopContext : DbContext
    {
        public ClothingShopContext(DbContextOptions<ClothingShopContext> options) : base(options)
        {

        }

        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
