using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;

namespace VirtualVideostore.Service.Interfaces
{
    public interface IActorService
    {
        void Add(Actor actor);

        void Edit(Actor actor);

        void Delete(Actor actor);

        Actor GetActorById(int Id);

        IEnumerable<Actor> GetActors();
    }
}
