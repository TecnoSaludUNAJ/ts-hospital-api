using Microsoft.AspNetCore.Mvc;
using System;
using TP_AccessData;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialistasController : ControllerBase
    {
        private readonly IEspecialistaService _service;

        public EspecialistasController(IEspecialistaService service, TemplateDbContext context)
        {
            _service = service;
        }

        // POST: api/Especialistas
        [HttpPost]
        public IActionResult PostEspecialista(EspecialistaDto especialista)
        {
            try
            {
                return new JsonResult(_service.CreateEspecialista(especialista)) { StatusCode = 201 };
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
