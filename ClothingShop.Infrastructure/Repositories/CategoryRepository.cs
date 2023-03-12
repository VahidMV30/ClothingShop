using ClothingShop.Application.Contracts.Repositories;
using ClothingShop.Domain.Entities;

namespace ClothingShop.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<long, Category>, ICategoryRepository
    {
        private readonly ClothingShopContext _context;

        public CategoryRepository(ClothingShopContext context) : base(context)
        {
            _context = context;
        }
    }
}
