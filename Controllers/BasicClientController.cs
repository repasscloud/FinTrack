using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinTrack.Data;
using FinTrack.Models.Clients;

namespace FinTrack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicClientController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BasicClientController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicClient
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicClient>>> GetBasicClients()
        {
          if (_context.BasicClients == null)
          {
              return NotFound();
          }
            return await _context.BasicClients.ToListAsync();
        }

        // GET: api/BasicClient/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasicClient>> GetBasicClient(int id)
        {
          if (_context.BasicClients == null)
          {
              return NotFound();
          }
            var basicClient = await _context.BasicClients.FindAsync(id);

            if (basicClient == null)
            {
                return NotFound();
            }

            return basicClient;
        }

        // PUT: api/BasicClient/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasicClient(int id, BasicClient basicClient)
        {
            if (id != basicClient.Id)
            {
                return BadRequest();
            }

            _context.Entry(basicClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasicClientExists(id))
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

        // POST: api/BasicClient
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BasicClient>> PostBasicClient(BasicClient basicClient)
        {
          if (_context.BasicClients == null)
          {
              return Problem("Entity set 'AppDbContext.BasicClients'  is null.");
          }
            _context.BasicClients.Add(basicClient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBasicClient", new { id = basicClient.Id }, basicClient);
        }

        // DELETE: api/BasicClient/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasicClient(int id)
        {
            if (_context.BasicClients == null)
            {
                return NotFound();
            }
            var basicClient = await _context.BasicClients.FindAsync(id);
            if (basicClient == null)
            {
                return NotFound();
            }

            _context.BasicClients.Remove(basicClient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BasicClientExists(int id)
        {
            return (_context.BasicClients?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
