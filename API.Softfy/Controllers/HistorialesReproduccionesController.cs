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
    public class HistorialesReproduccionesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HistorialesReproduccionesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/HistorialesReproducciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HistorialReproduccion>>> GetHistorialReproduccion()
        {
            return await _context.HistorialesReproducciones.ToListAsync();
        }

        // GET: api/HistorialesReproducciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HistorialReproduccion>> GetHistorialReproduccion(int id)
        {
            var historialReproduccion = await _context.HistorialesReproducciones.FindAsync(id);

            if (historialReproduccion == null)
            {
                return NotFound();
            }

            return historialReproduccion;
        }

        // PUT: api/HistorialesReproducciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistorialReproduccion(int id, HistorialReproduccion historialReproduccion)
        {
            if (id != historialReproduccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(historialReproduccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistorialReproduccionExists(id))
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

        // POST: api/HistorialesReproducciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HistorialReproduccion>> PostHistorialReproduccion(HistorialReproduccion historialReproduccion)
        {
            _context.HistorialesReproducciones.Add(historialReproduccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistorialReproduccion", new { id = historialReproduccion.Id }, historialReproduccion);
        }

        // DELETE: api/HistorialesReproducciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistorialReproduccion(int id)
        {
            var historialReproduccion = await _context.HistorialesReproducciones.FindAsync(id);
            if (historialReproduccion == null)
            {
                return NotFound();
            }

            _context.HistorialesReproducciones.Remove(historialReproduccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HistorialReproduccionExists(int id)
        {
            return _context.HistorialesReproducciones.Any(e => e.Id == id);
        }
    }
}
