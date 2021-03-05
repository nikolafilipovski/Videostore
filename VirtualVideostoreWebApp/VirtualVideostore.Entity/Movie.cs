using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VirtualVideostore.Entity
{
    public class Movie
    {
        [Key]
        public int movieId { get; set; }

        [StringLength(100)]
        public string title { get; set; }

        public string runTime { get; set; }

        public DateTime releaseDate { get; set; }

        public double rating { get; set; }

        [StringLength(50)]
        public string genre { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public Movie director { get; set; }

        public int directorId { get; set; }

        public Actor actor { get; set; }

        public int actorId { get; set; }

        public Watchlist wishlist { get; set; }

        public int wishlistId { get; set; }

    }
}
