using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET: api/sample
        [HttpGet("Get")]
        public IActionResult Get()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Master;Trusted_Connection=True;MultipleActiveResultSets=true");
                // writing sql query  

                // Opening Connection  

            }
            catch (Exception ex)
            {

            }
            return Ok("This is a sample GET response.");
        }
    }
}