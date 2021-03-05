using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualVideostore.Data;
using VirtualVideostore.Entity;
using VirtualVideostore.Repository.Interfaces;

namespace VirtualVideostore.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly DataContext _context;

        public DirectorRepository(DataContext context)
        {
            _context = context;
        }

        public void AddDirector(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void DeleteDirector(Director director)
        {
            _context.Directors.Remove(director);
            _context.SaveChanges();
        }

        public void EditDirector(Director director)
        {
            _context.Directors.Update(director);
            _context.SaveChanges();
        }

        public Director GetDirectorById(int Id)
        {
            var result = _context.Directors.FirstOrDefault(x => x.directorId == Id);
            return result;
        }

        public IEnumerable<Director> GetDirectors()
        {
            var result = _context.Directors.AsEnumerable();
            return result;
        }
    }
}
    
