using eMediaStore.Models;
using Microsoft.EntityFrameworkCore;

namespace eMediaStore.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(Actor actor)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Actor>> getAllAsync()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newactor)
        {
            _context.Update(newactor);
            await _context.SaveChangesAsync();
            return newactor;
        }
    }
}
