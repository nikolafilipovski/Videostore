using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;
using VirtualVideostore.Repository.Interfaces;
using VirtualVideostore.Service.Interfaces;

namespace VirtualVideostore.Service
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public void Add(Actor actor)
        {
            _actorRepository.AddActor(actor);
        }

        public void Delete(Actor actor)
        {
            _actorRepository.DeleteActor(actor);
        }

        public void Edit(Actor actor)
        {
            _actorRepository.EditActor(actor);
        }

        public Actor GetActorById(int Id)
        {
            var result = _actorRepository.GetActorById(Id);
            return result;
        }

        public IEnumerable<Actor> GetActors()
        {
            var result = _actorRepository.GetActors();
            return result;
        }
    }
}
