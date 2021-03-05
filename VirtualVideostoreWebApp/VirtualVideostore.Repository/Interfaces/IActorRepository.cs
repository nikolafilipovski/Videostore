using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;

namespace VirtualVideostore.Repository.Interfaces
{
    public interface IActorRepository
    {
        void AddActor(Actor actor);

        void EditActor(Actor actor);

        void DeleteActor(Actor actor);

        Actor GetActorById(int Id);

        IEnumerable<Actor> GetActors();
    }
}
