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
        public IActionResult GetAll([FromQuery] int IdEspecialidad)
        {
            try
            {
                return new JsonResult(_service.GetAll(IdEspecialidad)) { StatusCode = 200 };
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{Id?}")]
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
        public IActionResult Post(ProfesionalDto profesional)
        {
            try
            {
                //if (Validacion.ValidarNombre(profesional.Apellido) && Validacion.ValidarNombre(profesional.Nombre) 
                //    && Validacion.ValidarFecha(profesional.FechaNacimiento)&& Validacion.ValidarDni(profesional.Dni))
                if(true)
                {
                    return new JsonResult(_service.CreateProfesional(profesional)) { StatusCode = 201 };
                }
                throw new Exception();
              
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
