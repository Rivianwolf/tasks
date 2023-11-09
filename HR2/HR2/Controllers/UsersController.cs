using HR2.Data;
using HR2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Text;
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
            static string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                    byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < hashedBytes.Length; i++)
                    {
                        builder.Append(hashedBytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            string hashedPassword = HashPassword(data.Password);

            var User = new User()
            {
                //Id = data.Id,
                UserName = data.UserName,
                Password = hashedPassword,
                IsActive = data.IsActive,


            };
            var response = _context.Users.Add(User);
            _context.SaveChanges();

            return null;
        }


        [HttpPost("LoginUser")]
        [SwaggerOperation(Summary = "Login User")]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]
        public Task<ActionResult<IEnumerable<UserLogin>>> UserLogin([FromBody] UserLogin data)
        {

            var User = new User()
            {
                
                UserName = data.Username,
                Password = data.Password,
            };

            return null;

        }
    }

}


