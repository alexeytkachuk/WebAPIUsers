using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIUsers.Models
{
    public class Context
    {
        public interface IRepository
        {
            public IEnumerable<User> Users { get; set; }
            User GetUsers();
            User GetUser(string LastName);
            User AddUser(User user);
            User UpdateUser(User user);
            void DeleteUser(string LastName);
        }
    }
}
