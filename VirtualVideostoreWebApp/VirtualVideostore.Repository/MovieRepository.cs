using System;
using System.Collections.Generic;
using System.Linq;
using VirtualVideostore.Data;
using VirtualVideostore.Entity;
using VirtualVideostore.Repository.Interfaces;

namespace VirtualVideostore.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }

        public Movie GetMovieById(int Id)
        {
            var result = _context.Movies.FirstOrDefault(x => x.movieId == Id);
            return result;
        }

        public IEnumerable<Movie> GetMovies()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }
    }
}
