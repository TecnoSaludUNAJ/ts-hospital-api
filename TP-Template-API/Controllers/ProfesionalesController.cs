using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_AccessData;
using TP_Domain.Entities;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesionalesController : ControllerBase
    {
        private readonly TemplateDbContext _context;

        public ProfesionalesController(TemplateDbContext context)
        {
            _context = context;
        }

        // GET: api/Profesionales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesional>>> GetProfesionales()
        {
            return await _context.Profesionales.ToListAsync();
        }

        // GET: api/Profesionales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesional>> GetProfesional(int id)
        {
            var profesional = await _context.Profesionales.FindAsync(id);

            if (profesional == null)
            {
                return NotFound();
            }

            return profesional;
        }

        // PUT: api/Profesionales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesional(int id, Profesional profesional)
        {
            if (id != profesional.Id)
            {
                return BadRequest();
            }

            _context.Entry(profesional).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesionalExists(id))
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

        // POST: api/Profesionales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Profesional>> PostProfesional(Profesional profesional)
        {
            _context.Profesionales.Add(profesional);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfesional", new { id = profesional.Id }, profesional);
        }

        // DELETE: api/Profesionales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Profesional>> DeleteProfesional(int id)
        {
            var profesional = await _context.Profesionales.FindAsync(id);
            if (profesional == null)
            {
                return NotFound();
            }

            _context.Profesionales.Remove(profesional);
            await _context.SaveChangesAsync();

            return profesional;
        }

        private bool ProfesionalExists(int id)
        {
            return _context.Profesionales.Any(e => e.Id == id);
        }
    }
}
