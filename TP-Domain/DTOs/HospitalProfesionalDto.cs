using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Entities;

namespace TP_Domain.DTOs
{
    public class HospitalProfesionalDto
    {
        public Guid IdHospitalProfesional { get; set; }

        //Foreign Key
        public Hospital Hospital { get; set; }
        public Profesional Profesional { get; set; }
    }
}
