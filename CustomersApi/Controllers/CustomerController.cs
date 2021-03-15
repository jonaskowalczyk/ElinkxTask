using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerContext _context;

        public CustomerController(CustomerContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerObject>>> GetTbCustomers()
        {
            return await _context.TbCustomers.ToListAsync();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerObject>> GetCustomerObject(int id)
        {
            var customerObject = await _context.TbCustomers.FindAsync(id);

            if (customerObject == null)
            {
                return NotFound();
            }

            return customerObject;
        }

        // PUT: api/Customer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerObject(int id, CustomerObject customerObject)
        {
            if (id != customerObject.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerObject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerObjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerObject>> PostCustomerObject(CustomerObject customerObject)
        {
            _context.TbCustomers.Add(customerObject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerObject", new { id = customerObject.Id }, customerObject);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerObject(int id)
        {
            var customerObject = await _context.TbCustomers.FindAsync(id);
            if (customerObject == null)
            {
                return NotFound();
            }

            _context.TbCustomers.Remove(customerObject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerObjectExists(int id)
        {
            return _context.TbCustomers.Any(e => e.Id == id);
        }
    }
}
