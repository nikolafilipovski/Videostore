using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;

namespace VirtualVideostore.Repository.Interfaces
{
    public interface IDirectorRepository
    {
        void AddDirector(Director director);

        void EditDirector(Director director);

        void DeleteDirector(Director director);

        Director GetDirectorById(int Id);

        IEnumerable<Director> GetDirectors();
    }
}
