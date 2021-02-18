using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIUsers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIUsers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private Models.Context.IRepository repository { get; set; }

        [HttpGet]
        public IEnumerable<User> GetUsers() => repository.Users;
        [HttpGet("{LastName}")]
        public User GetUser(string LastName) => repository.GetUser(LastName);
        [HttpPost]
        public User AddUser([FromBody] User user) => repository.AddUser(new User { FirstName = user.FirstName, LastName = user.LastName, Age = user.Age, Email = user.Email, PhoneNumber = user.PhoneNumber, HomeAdress = user.HomeAdress });
        [HttpPut]
        public User UpdateUser([FromBody] User user) => repository.UpdateUser(user);
        [HttpDelete("{LastName}")]
        public void DeleteUser(string LastName) => repository.DeleteUser(LastName);


       
    }
}
