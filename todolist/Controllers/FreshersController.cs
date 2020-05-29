using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todolist.Models;

namespace todolist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreshersController : ControllerBase
    {
        private readonly EmployeedbContext _context;

        public FreshersController(EmployeedbContext context)
        {
            _context = context;
        }

        // GET: api/Freshers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fresher>>> GetFresher()
        {
            return await _context.Fresher.ToListAsync();
        }

        // GET: api/Freshers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fresher>> GetFresher(string id)
        {
            var fresher = await _context.Fresher.FindAsync(id);

            if (fresher == null)
            {
                return NotFound();
            }

            return fresher;
        }

        // PUT: api/Freshers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFresher(string id, Fresher fresher)
        {
            if (id != fresher.FresherId)
            {
                return BadRequest();
            }

            _context.Entry(fresher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FresherExists(id))
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

        // POST: api/Freshers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Fresher>> PostFresher(Fresher fresher)
        {
            _context.Fresher.Add(fresher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFresher", new { id = fresher.FresherId }, fresher);
        }

        // DELETE: api/Freshers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fresher>> DeleteFresher(string id)
        {
            var fresher = await _context.Fresher.FindAsync(id);
            if (fresher == null)
            {
                return NotFound();
            }

            _context.Fresher.Remove(fresher);
            await _context.SaveChangesAsync();

            return fresher;
        }

        private bool FresherExists(string id)
        {
            return _context.Fresher.Any(e => e.FresherId == id);
        }
    }
}
