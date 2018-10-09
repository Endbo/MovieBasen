using MovieBasen.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieBasen.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You must fill in a name to the movie.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "You must fill in the year the movie premiered")]
        [Range(1950, 2050, ErrorMessage = "It must be between 1950 and 2017")]
        public int Year { get; set; }

        [Required(ErrorMessage = "You must fill in the synopsis of the movie")]
        public String Synopsis { get; set; }

        public String MovieImagePath { get; set; }

        public void SaveImage(HttpPostedFileBase image, String serverPath, String pathToFile)
        {
            if (image == null) return;

            //ImageModel
            Guid guid = Guid.NewGuid();
            ImageModel.ResizeAndSave(serverPath + pathToFile, guid.ToString(), image.InputStream, 275);

            MovieImagePath = pathToFile + guid.ToString() + ".jpg";
        }

        public virtual ICollection<MovieGenre> MoviesGenres { get; set; }

        public virtual ICollection<MovieActor> MoviesActors { get; set; }

    }

}