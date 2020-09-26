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
    public class HospitalProfesionalController : ControllerBase
    {
        private readonly TemplateDbContext _context;

        public HospitalProfesionalController(TemplateDbContext context)
        {
            _context = context;
        }

        // GET: api/HospitalProfesional
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HospitalProfesional>>> GetHospitalProfesionalList()
        {
            return await _context.HospitalProfesionalList.ToListAsync();
        }

        // GET: api/HospitalProfesional/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HospitalProfesional>> GetHospitalProfesional(int id)
        {
            var hospitalProfesional = await _context.HospitalProfesionalList.FindAsync(id);

            if (hospitalProfesional == null)
            {
                return NotFound();
            }

            return hospitalProfesional;
        }

        // PUT: api/HospitalProfesional/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospitalProfesional(int id, HospitalProfesional hospitalProfesional)
        {
            if (id != hospitalProfesional.Id)
            {
                return BadRequest();
            }

            _context.Entry(hospitalProfesional).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HospitalProfesionalExists(id))
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

        // POST: api/HospitalProfesional
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HospitalProfesional>> PostHospitalProfesional(HospitalProfesional hospitalProfesional)
        {
            _context.HospitalProfesionalList.Add(hospitalProfesional);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHospitalProfesional", new { id = hospitalProfesional.Id }, hospitalProfesional);
        }

        // DELETE: api/HospitalProfesional/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HospitalProfesional>> DeleteHospitalProfesional(int id)
        {
            var hospitalProfesional = await _context.HospitalProfesionalList.FindAsync(id);
            if (hospitalProfesional == null)
            {
                return NotFound();
            }

            _context.HospitalProfesionalList.Remove(hospitalProfesional);
            await _context.SaveChangesAsync();

            return hospitalProfesional;
        }

        private bool HospitalProfesionalExists(int id)
        {
            return _context.HospitalProfesionalList.Any(e => e.Id == id);
        }
    }
}
