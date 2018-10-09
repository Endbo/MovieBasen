using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieBasen.Models
{
    public class Actor
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You must fill in a Firstname to the movie.")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "You must fill in a Lastname to the movie.")]
        public String LastName { get; set; }

        [NotMapped]
        public String FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }

            set { }
        }
        [Required(ErrorMessage = "You must fill in the date of birth of the person")]
        [Range(typeof(DateTime), "1/2/1880", "1/2/2050", ErrorMessage = "It must be between 1880 and 2017")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        
   
        public virtual ICollection<MovieActor> MoviesActors { get; set; }
    }
}
