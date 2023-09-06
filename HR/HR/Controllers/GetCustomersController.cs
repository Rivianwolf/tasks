using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCustomersController : ControllerBase
    {
        // GET: api/sample
        [HttpGet]
        public IActionResult Get()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cnn.Close();
            return Ok("This is a sample GET response.");
        }
    }
}