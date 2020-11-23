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

        [HttpGet("{Id?}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                EspecialistaDto esp = _service.GetById(Id);
                if (esp != null)
                {
                    return new JsonResult(esp) { StatusCode = 200 };
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return NotFound();
            }
        }


        [HttpGet]
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
