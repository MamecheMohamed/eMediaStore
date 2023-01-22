using eMediaStore.Models;

namespace eMediaStore.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> getAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        void Delete(Actor actor);
        Actor Update(int id, Actor newactor);


    }
}
