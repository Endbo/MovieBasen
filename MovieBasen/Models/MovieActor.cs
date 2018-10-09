using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBasen.Models
{
    public class MovieActor
    {
        public int ID { get; set; }

        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }

        public int ActorID { get; set; }
        public virtual Actor Actor { get; set; }
    }
}