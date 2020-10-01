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
     class HospitalesController : ControllerBase
    {
        private readonly HospitalService _service;

        public HospitalesController(HospitalService service)
        {
            _service = service;
        }

        // POST: api/Hospitales      
        [HttpPost]
        public IActionResult PostHospital(HospitalDto hospital)
        {
            try
            {
               return new JsonResult(_service.CreateHospital(hospital)) { StatusCode=201};            
            }
            catch (Exception)
            {
                return BadRequest();
            }                   
        }

        //GET: api/Hospitales
        [HttpGet]
        public IActionResult GetHospitales()
        {
            try
            {
                return new JsonResult(_service) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }










    }
}
