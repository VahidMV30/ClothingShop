using System.Linq.Expressions;
using ClothingShop.Application.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClothingShop.Infrastructure.Repositories
{
    public class GenericRepository<TKey, T> : IGenericRepository<TKey, T> where T : class
    {
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetBy(TKey id)
        {
            return await _context.FindAsync<T>(id);
        }

        public async Task<bool> Includes(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().AnyAsync(expression);
        }

        public async Task Create(T entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
