using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;

namespace VirtualVideostore.Service.Interfaces
{
    public interface IDirectorService
    {
        void Add(Director director);

        void Edit(Director director);

        void Delete(Director director);

        Director GetDirectorById(int Id);

        IEnumerable<Director> GetDirectors();
    }
}
