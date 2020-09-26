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
    public class EspecialidadesController : ControllerBase
    {
        private readonly EspecialidadService _service;

        public EspecialidadesController(EspecialidadService service)
        {
            _service = service;
        }

        [HttpPost()]
        public IActionResult Post(EspecialidadDto especialidad)
        {
            try
            {
                return new JsonResult(_service.CreateEspecialidad(especialidad)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{Id?}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                return new JsonResult(_service.GetEspecialidadById(Id)) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Getall()
        {
            try
            {
                return new JsonResult(_service.GetAllEspecialidades()) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }
}
