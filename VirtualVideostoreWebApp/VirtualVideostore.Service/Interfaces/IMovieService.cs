using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Entity;

namespace VirtualVideostore.Service.Interfaces
{
    public interface IMovieService
    {
        void Add(Movie movie);

        void Edit(Movie movie);

        void Delete(Movie movie);

        Movie GetMovieById(int Id);

        IEnumerable<Movie> GetMovies();
    }
}
