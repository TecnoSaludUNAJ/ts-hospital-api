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
    class ProfesionalConsultorioController : ControllerBase
    {
        private readonly TemplateDbContext _context;

        public ProfesionalConsultorioController(TemplateDbContext context)
        {
            _context = context;
        }

        // GET: api/ProfesionalConsultorio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfesionalConsultorio>>> GetProfesionalConsultorioList()
        {
            return await _context.ProfesionalConsultorioList.ToListAsync();
        }

        // GET: api/ProfesionalConsultorio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfesionalConsultorio>> GetProfesionalConsultorio(int id)
        {
            var profesionalConsultorio = await _context.ProfesionalConsultorioList.FindAsync(id);

            if (profesionalConsultorio == null)
            {
                return NotFound();
            }

            return profesionalConsultorio;
        }

        // PUT: api/ProfesionalConsultorio/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesionalConsultorio(int id, ProfesionalConsultorio profesionalConsultorio)
        {
            if (id != profesionalConsultorio.Id)
            {
                return BadRequest();
            }

            _context.Entry(profesionalConsultorio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesionalConsultorioExists(id))
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

        // POST: api/ProfesionalConsultorio
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProfesionalConsultorio>> PostProfesionalConsultorio(ProfesionalConsultorio profesionalConsultorio)
        {
            _context.ProfesionalConsultorioList.Add(profesionalConsultorio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfesionalConsultorio", new { id = profesionalConsultorio.Id }, profesionalConsultorio);
        }

        // DELETE: api/ProfesionalConsultorio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfesionalConsultorio>> DeleteProfesionalConsultorio(int id)
        {
            var profesionalConsultorio = await _context.ProfesionalConsultorioList.FindAsync(id);
            if (profesionalConsultorio == null)
            {
                return NotFound();
            }

            _context.ProfesionalConsultorioList.Remove(profesionalConsultorio);
            await _context.SaveChangesAsync();

            return profesionalConsultorio;
        }

        private bool ProfesionalConsultorioExists(int id)
        {
            return _context.ProfesionalConsultorioList.Any(e => e.Id == id);
        }
    }
}
