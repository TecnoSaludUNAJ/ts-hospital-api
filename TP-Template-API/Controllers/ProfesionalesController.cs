using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_AccessData;
using TP_Application.Services;
using TP_Domain.DTOs;
using TP_Domain.Entities;

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
                return new JsonResult(_service.GetAll(IdEspecialidad)) { StatusCode=200};
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{Id?}")]
        public IActionResult GetById(int Id)
        {
            ResponseProfesional prof = _service.GetProfesionalById(Id);
            if (prof != null)
            {
                return new JsonResult(prof) { StatusCode = 200 };
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
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


    }
}
