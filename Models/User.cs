using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIUsers.Controllers;

namespace WebAPIUsers.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAdress { get; set; }
       
    }
}
