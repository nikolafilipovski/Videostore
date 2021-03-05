using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VirtualVideostore.Entity
{
    public class Actor
    {
        [Key]
        public int actorId { get; set; }

        [StringLength(20)]
        public string firstName { get; set; }

        [StringLength(30)]
        public string lastName { get; set; }

        public DateTime birthday { get; set; }

        [StringLength(30)]
        public string nationality { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
