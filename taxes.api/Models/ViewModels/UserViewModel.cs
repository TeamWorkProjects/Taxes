using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taxes.api.Models.ViewModels
{
    public class UserViewModel
    {
        public string Password { get; set; }
        public string Email { get; set; }
        //public string Login{ get; set; } use Email as Login?
    }
}
