using eMediaStore.Models;

namespace eMediaStore.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> getAll();
        Actor GetById(int id);
        void Add(Actor actor);
        void Delete(Actor actor);
        Actor Update(int id, Actor newactor);


    }
}
