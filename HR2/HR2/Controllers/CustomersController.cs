﻿using HR2.Data;
using HR2.Entity;
using HR2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> GetAsync()
        {
            List<GetCustomer> getCustomer = new List<GetCustomer>();
            var response = await _context.Customers
                .Include(x => x.Gender)
                .Include (y => y.PhoneNumbers)
                .ToListAsync();

            foreach (var item in response)
            {
                var phoneNumbers = item.PhoneNumbers.Select(p => new PhoneNumberModel
                {
                    PhoneNumber = p.PhoneNumber,
                    IsDefault = p.IsDefault

                }).ToList();
                getCustomer.Add(new GetCustomer()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    GenderId = item.GenderId,
                    GenderName = item.Gender.Name,
                    DateOfBirth = item.DateOfBirth,
                    PhoneNumbers = phoneNumbers

                });
            }
            return Ok(getCustomer);
        }
        //InsertCustomer with POST
        [HttpPost("insertCustomer")]
    [SwaggerOperation(Summary = "Insert Customer in DB")]
     [ProducesResponseType(typeof(Customer), (int)HttpStatusCode.OK)]

        public async Task<ActionResult<IEnumerable<Customer>>> InsertCustomers([FromBody] InsertCustomer data)
    {
            var phoneNumber = data.PhoneNumbers.Select(p => new PhoneNumbers
            {
                PhoneNumber = p.PhoneNumber,
                //IsDefault = p.IsDefault

            }).ToList();
            var customers = new Customer()
        {
            FirstName = data.FirstName,
            LastName = data.LastName,
            DateOfBirth = data.DateOfBirth,
            GenderId = data.GenderId,
            PhoneNumbers = phoneNumber

            };
            var response = _context.Customers.Add(customers);
            _context.SaveChanges();


                var responseData = new ApiResponse

                {
                    Success = true,
                    Message = "Success",
                    Data = customers.Id
                };
                
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

        [ApiController]
        [Route("api/[controller]")]
        public class AuthController : ControllerBase
        {
            private readonly IAuthService _authService;

            public AuthController(IAuthService authService)
            {
                _authService = authService;
            }

            [HttpPost("login")]
            public async Task<IActionResult> Login([FromBody] UserLogin model)
            {
                var token = await _authService.AuthenticateAsync(model.Username, model.Password);

                if (token == null)
                {
                    return Unauthorized("Invalid username or password");
                }

                return Ok(new { Token = token });
            }
        }
    }

}