using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ClothingShop.Infrastructure
{
    public class ClothingShopContextFactory : IDesignTimeDbContextFactory<ClothingShopContext>
    {
        private readonly IConfiguration _configuration;

        public ClothingShopContextFactory()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appSettings.Development.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();
        }

        public ClothingShopContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClothingShopContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ClothingShop"));
            return new ClothingShopContext(optionsBuilder.Options);
        }
    }
}
