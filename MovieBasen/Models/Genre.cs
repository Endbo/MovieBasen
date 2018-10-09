using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieBasen.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You must fill in the genre name of the the movie.")]
        public String Name { get; set; }

        public virtual ICollection<MovieGenre> MoviesGenres { get; set; }

    }
}