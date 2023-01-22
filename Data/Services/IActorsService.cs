using eMediaStore.Models;

namespace eMediaStore.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> getAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        void Delete(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newactor);


    }
}
