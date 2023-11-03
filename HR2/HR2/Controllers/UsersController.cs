using HR2.Data;
using HR2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace HR2.Controllers
{
    public class UsersController
    {
        private readonly AppDbContext _context; //ჩემი უნდა გავწერო

        public UsersController(AppDbContext context) //ჩემი უნდა გავწერო
        {
            _context = context;
        }

        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        [HttpPost("RegisterUser")]
        [SwaggerOperation(Summary = "Insert User in DB")]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]

        public async Task<ActionResult<IEnumerable<User>>> UserRegistration([FromBody] UserRegistration data)
        {
            var User = new User()
            {
                //Id = data.Id,
                UserName = data.UserName,
                Password = data.Password,
                IsActive = data.IsActive,


            };
            var response = _context.Users.Add(User);
            _context.SaveChanges();

            return null;
        }


    }

}


