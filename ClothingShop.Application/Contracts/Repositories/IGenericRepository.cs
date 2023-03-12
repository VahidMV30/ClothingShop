using System.Linq.Expressions;

namespace ClothingShop.Application.Contracts.Repositories
{
    public interface IGenericRepository<TKey, T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetBy(TKey id);
        Task<bool> Includes(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task SaveChanges();
    }
}
