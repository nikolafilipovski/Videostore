using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;
using VirtualVideostore.Repository.Interfaces;
using VirtualVideostore.Service.Interfaces;

namespace VirtualVideostore.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public void Delete(Movie movie)
        {
            _movieRepository.DeleteMovie(movie);
        }

        public void Edit(Movie movie)
        {
            _movieRepository.EditMovie(movie);
        }

        public Movie GetMovieById(int Id)
        {
            var result = _movieRepository.GetMovieById(Id);
            return result;
        }

        public IEnumerable<Movie> GetMovies()
        {
            var result = _movieRepository.GetMovies();
            return result;
        }
    }
}
