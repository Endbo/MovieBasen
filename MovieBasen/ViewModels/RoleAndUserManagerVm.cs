using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBasen.ViewModels
{
    public class RoleAndUserManagerVm
    {
        public List<string> UsersName { get; set; }
        public List<string> UsersEmailName { get; set; }
        public List<string> UsersRole { get; set; }


    }
}


