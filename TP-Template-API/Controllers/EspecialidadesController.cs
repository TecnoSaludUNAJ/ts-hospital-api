using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadesController : ControllerBase
    {
        private readonly IEspecialidadService _service;

        public EspecialidadesController(IEspecialidadService service)
        {
            _service = service;
        }

        [HttpPost()]
        [Authorize]
        public IActionResult Post(EspecialidadDto especialidad)
        {
            
            try
            {
                if (Validacion.ValidarNombre(especialidad.TipoEspecialidad))
                {
                    return new JsonResult(_service.CreateEspecialidad(especialidad)) { StatusCode = 201 };
                }
                throw new Exception();
                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{Id?}")]
        [Authorize]
        public IActionResult GetById(int Id)
        {
            try
            {
                ResponseEspecialidad esp = _service.GetById(Id);
                if (esp != null)
                {
                    return new JsonResult(esp) { StatusCode = 200 };
                }
                else {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return NotFound();
            }         
        }

        [HttpGet]
        [Authorize]
        public IActionResult Getall()
        {
            try
            {
                return new JsonResult(_service.GetAll()) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
