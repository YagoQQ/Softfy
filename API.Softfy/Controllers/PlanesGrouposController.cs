using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Softfy.Data;
using Modelos.Softfy;

namespace API.Softfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanesGrouposController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlanesGrouposController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PlanesGroupos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanGroup>>> GetPlanGroup()
        {
            return await _context.PlanesGroupos.ToListAsync();
        }

        // GET: api/PlanesGroupos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanGroup>> GetPlanGroup(int id)
        {
            var planGroup = await _context.PlanesGroupos.FindAsync(id);

            if (planGroup == null)
            {
                return NotFound();
            }

            return planGroup;
        }

        // PUT: api/PlanesGroupos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanGroup(int id, PlanGroup planGroup)
        {
            if (id != planGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(planGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanGroupExists(id))
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

        // POST: api/PlanesGroupos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlanGroup>> PostPlanGroup(PlanGroup planGroup)
        {
            _context.PlanesGroupos.Add(planGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanGroup", new { id = planGroup.Id }, planGroup);
        }

        // DELETE: api/PlanesGroupos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanGroup(int id)
        {
            var planGroup = await _context.PlanesGroupos.FindAsync(id);
            if (planGroup == null)
            {
                return NotFound();
            }

            _context.PlanesGroupos.Remove(planGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanGroupExists(int id)
        {
            return _context.PlanesGroupos.Any(e => e.Id == id);
        }
    }
}
