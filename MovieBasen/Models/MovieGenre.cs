using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBasen.Models
{
    public class MovieGenre
    {
        public int ID { get; set; }

        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }

        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}