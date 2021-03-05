using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;
using VirtualVideostore.Repository.Interfaces;
using VirtualVideostore.Service.Interfaces;

namespace VirtualVideostore.Service
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void Add(Director director)
        {
            _directorRepository.AddDirector(director);
        }

        public void Delete(Director director)
        {
            _directorRepository.DeleteDirector(director);
        }

        public void Edit(Director director)
        {
            _directorRepository.EditDirector(director);
        }

        public Director GetDirectorById(int Id)
        {
            var result = _directorRepository.GetDirectorById(Id);
            return result;
        }

        public IEnumerable<Director> GetDirectors()
        {
            var result = _directorRepository.GetDirectors();
            return result;
        }
    }
}
