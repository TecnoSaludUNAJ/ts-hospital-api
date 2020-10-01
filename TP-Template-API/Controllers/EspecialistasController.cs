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
   
    public class EspecialistasController : ControllerBase
    {
        private readonly IEspecialistaService _service;

        public EspecialistasController(IEspecialistaService service)
        {
            _service = service;
        }

        // POST: api/Especialistas      
        [HttpPost]
        public IActionResult Post(EspecialistaDto especialista)
        {       
                return new JsonResult(_service.CreateEspecialista(especialista)) { StatusCode = 201 };         
        }     
    }
}
