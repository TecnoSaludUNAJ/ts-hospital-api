using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesionalesController : ControllerBase
    {
        private readonly IProfesionalService _service;

        public ProfesionalesController(IProfesionalService service)
        {
            _service = service;
        }

        // GET: api/Profesionales
        [HttpGet]
        [Authorize]
        public IActionResult GetAll([FromQuery] int IdEspecialidad, [FromQuery] int UsuarioId)
        {
            try
            {
                return new JsonResult(_service.GetAll(IdEspecialidad,UsuarioId)) { StatusCode = 200 };
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{Id?}")]
        [Authorize]
        public IActionResult GetById(int Id)
        {
            try
            {
                ResponseProfesional prof = _service.GetProfesionalById(Id);
                if (prof != null)
                {
                    return new JsonResult(prof) { StatusCode = 200 };
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return NotFound();
            }
           
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post(ProfesionalDto profesional)
        {
            try
            {

                return new JsonResult(_service.CreateProfesional(profesional)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("userId/{Id?}")]
        [Authorize]
        public IActionResult GetByUserId(int Id)
        {
            try
            {
                ResponseProfesionalAndEspecialidades prof = _service.GetProfesionalByUserId(Id);
                if (prof != null)
                {
                    return new JsonResult(prof) { StatusCode = 200 };
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return NotFound();
            }

        }
    }
}
