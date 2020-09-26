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
    public class EspecialistasController : ControllerBase
    {
        private readonly TemplateDbContext _context;

        public EspecialistasController(TemplateDbContext context)
        {
            _context = context;
        }

        // GET: api/Especialistas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialista>>> GetEspecialistas()
        {
            return await _context.Especialistas.ToListAsync();
        }

        // GET: api/Especialistas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Especialista>> GetEspecialista(int id)
        {
            var especialista = await _context.Especialistas.FindAsync(id);

            if (especialista == null)
            {
                return NotFound();
            }

            return especialista;
        }

        // PUT: api/Especialistas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspecialista(int id, Especialista especialista)
        {
            if (id != especialista.Id)
            {
                return BadRequest();
            }

            _context.Entry(especialista).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecialistaExists(id))
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

        // POST: api/Especialistas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Especialista>> PostEspecialista(Especialista especialista)
        {
            _context.Especialistas.Add(especialista);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecialista", new { id = especialista.Id }, especialista);
        }

        // DELETE: api/Especialistas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Especialista>> DeleteEspecialista(int id)
        {
            var especialista = await _context.Especialistas.FindAsync(id);
            if (especialista == null)
            {
                return NotFound();
            }

            _context.Especialistas.Remove(especialista);
            await _context.SaveChangesAsync();

            return especialista;
        }

        private bool EspecialistaExists(int id)
        {
            return _context.Especialistas.Any(e => e.Id == id);
        }
    }
}
