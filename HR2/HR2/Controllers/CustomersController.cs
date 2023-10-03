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
    public class ApiResponse
    {
        public bool Success
        {
            get; set;
        }
        public string Message
        {
            get; set;
        }
        public object Data
        {
            get; set;
        }
    }


    [Route("api/[controller]")]
[ApiController]

public class CustomersController : ControllerBase
{
    private readonly AppDbContext _context; //ჩემი უნდა გავწერო

    public CustomersController(AppDbContext context) //ჩემი უნდა გავწერო
    {
        _context = context;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get Customers Info")]
    [ProducesResponseType(typeof(Customer), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        //LINQ
    {
        var customers = await _context.Customers.ToListAsync();
        return Ok(customers);
    }
    //InsertCustomer with POST
    [HttpPost("insertCustomer")]
    [SwaggerOperation(Summary = "Insert Customer in DB")]
     [ProducesResponseType(typeof(Customer), (int)HttpStatusCode.OK)]

        public async Task<ActionResult<IEnumerable<Customer>>> InsertCustomers([FromBody] InsertCustomer data)
    {
        var customers = new Customer()
        {
            FirstName = data.FirstName,
            LastName = data.LastName,
            DateOfBirth = data.DateOfBirth,
            GenderId = data.GenderId,
        };

        
                var responseData = new ApiResponse

                {
                    Success = true,
                    Message = "Success",
                    Data = customers
                };
                var response = _context.Add(customers);
            _context.SaveChanges();
        return Ok(responseData);
    }
        [HttpDelete("deleteCustomer")]
        [SwaggerOperation(Summary = "Delete customer from DB")]
        [ProducesResponseType(typeof(Customer), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Customer>>> Delete(int id)

        { 
            var resourceToDelete = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(resourceToDelete);
            await _context.SaveChangesAsync();
                return Ok("Deleted Succesfully");
        }
    }

}