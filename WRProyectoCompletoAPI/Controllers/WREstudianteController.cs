using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WRProyectoCompletoAPI.Data;
using WRproyectoCompletoAPI.Models;

namespace WRProyectoCompletoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WREstudianteController : ControllerBase
    {
        private readonly WRProyectoCompletoAPIContext _context;

        public WREstudianteController(WRProyectoCompletoAPIContext context)
        {
            _context = context;
        }

        // GET: api/WREstudiante
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WREstudiante>>> GetWREstudiante()
        {
            return await _context.WREstudiante.ToListAsync();
        }

        // GET: api/WREstudiante/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WREstudiante>> GetWREstudiante(int id)
        {
            var wREstudiante = await _context.WREstudiante.FindAsync(id);

            if (wREstudiante == null)
            {
                return NotFound();
            }

            return wREstudiante;
        }

        // PUT: api/WREstudiante/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWREstudiante(int id, WREstudiante wREstudiante)
        {
            if (id != wREstudiante.WRestudianteId)
            {
                return BadRequest();
            }

            _context.Entry(wREstudiante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WREstudianteExists(id))
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

        // POST: api/WREstudiante
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WREstudiante>> PostWREstudiante(WREstudiante wREstudiante)
        {
            _context.WREstudiante.Add(wREstudiante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWREstudiante", new { id = wREstudiante.WRestudianteId }, wREstudiante);
        }

        // DELETE: api/WREstudiante/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWREstudiante(int id)
        {
            var wREstudiante = await _context.WREstudiante.FindAsync(id);
            if (wREstudiante == null)
            {
                return NotFound();
            }

            _context.WREstudiante.Remove(wREstudiante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WREstudianteExists(int id)
        {
            return _context.WREstudiante.Any(e => e.WRestudianteId == id);
        }
    }
}
