using ClothingShop.Application.Contracts.Services;
using ClothingShop.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClothingShop.Application
{
    public static class ApplicationServiceRegisteration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();

            return services;
        }
    }
}
