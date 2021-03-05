using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualVideostore.Data;
using VirtualVideostore.Entity;
using VirtualVideostore.Repository.Interfaces;

namespace VirtualVideostore.Repository
{
    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _context;

        public ActorRepository(DataContext context)
        {
            _context = context;
        }

        public void AddActor(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void DeleteActor(Actor actor)
        {
            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }

        public void EditActor(Actor actor)
        {
            _context.Actors.Update(actor);
            _context.SaveChanges();
        }

        public Actor GetActorById(int Id)
        {
            var result = _context.Actors.FirstOrDefault(x => x.actorId == Id);
            return result;
        }

        public IEnumerable<Actor> GetActors()
        {
            var result = _context.Actors.AsEnumerable();
            return result;
        }
    }
}
