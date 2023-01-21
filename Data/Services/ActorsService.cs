﻿using eMediaStore.Models;
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

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(Actor actor)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Actor>> getAll()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newactor)
        {
            throw new NotImplementedException();
        }
    }
}