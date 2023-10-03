using HR2.Data;
using HR2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
    public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        //LINQ
    {
        var customers = await _context.Customers.ToListAsync();
        return Ok(customers);
    }
    //InsertCustomer with POST
    [HttpPost("InsertCustomer")] 

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
}

}