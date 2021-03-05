using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VirtualVideostore.Entity
{
    public class Watchlist
    {
        [Key]
        public int watchlistId { get; set; }
        public int movieId { get; set; }

        public ICollection<Movie> Movies { get; set; }

    }
}
