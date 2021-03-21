using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomersApi.DbContexts;
using CustomersApi.Objects;


namespace CustomersApi.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerContext _context;

        public CustomersController(CustomerContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerObject>>> GetCustomers()
        {
            return await _context.TbCustomers.ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerObject>> GetCustomer(int id)
        {
            CustomerObject customerObject = await _context.TbCustomers.FindAsync(id);

            if (customerObject == null)
            {
                return new ContentResult()
                {
                    Content = "Customer does not exist.",
                    StatusCode = StatusCodes.Status403Forbidden
                };
            }

            return customerObject;
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, CustomerObject customerObject)
        {
            if (id != customerObject.Id)
            {
                return new ContentResult()
                {
                    Content = "You cannot change customer's id.",
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }

            _context.Entry(customerObject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return new ContentResult()
            {
                Content = "Customer has been updated.",
                StatusCode = StatusCodes.Status202Accepted
            };
        }

        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult<CustomerObject>> PostCustomer(CustomerObject customerObject)
        {

            if (CustomerExists(customerObject.Id))
            {
                return new ContentResult()
                {
                    Content = "Customer with this ID already exists.",
                    StatusCode = StatusCodes.Status403Forbidden
                };
            }

            _context.TbCustomers.Add(customerObject);
            await _context.SaveChangesAsync();

            return new ContentResult()
            {
                Content = "Customer has been created.",
                StatusCode = StatusCodes.Status201Created
            };
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            CustomerObject customerObject = await _context.TbCustomers.FindAsync(id);
            if (customerObject == null)
            {
                return new ContentResult()
                {
                    Content = "Customer does not exist.",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }

            _context.TbCustomers.Remove(customerObject);
            await _context.SaveChangesAsync();

            return new ContentResult()
            {
                Content = "Customer has been deleted.",
                StatusCode = StatusCodes.Status202Accepted
            };
        }

        private bool CustomerExists(int id)
        {
            return _context.TbCustomers.Any(e => e.Id == id);
        }
    }
}
