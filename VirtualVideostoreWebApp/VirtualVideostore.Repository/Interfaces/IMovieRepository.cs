using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;

namespace VirtualVideostore.Repository.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);

        void EditMovie(Movie movie);

        void DeleteMovie(Movie movie);

        Movie GetMovieById(int Id);

        IEnumerable<Movie> GetMovies();
    }
}
