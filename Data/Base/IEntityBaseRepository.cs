using eMediaStore.Models;

namespace eMediaStore.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class , IEntityBase,new()
    {
        Task<IEnumerable<T>> getAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, T entity);
    }
}
