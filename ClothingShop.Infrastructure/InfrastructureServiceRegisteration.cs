using ClothingShop.Application.Contracts.Repositories;
using ClothingShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClothingShop.Infrastructure
{
    public static class InfrastructureServiceRegisteration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ClothingShopContext>(options => options.UseSqlServer(configuration.GetConnectionString("ClothingShop")));

            services.AddTransient<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
