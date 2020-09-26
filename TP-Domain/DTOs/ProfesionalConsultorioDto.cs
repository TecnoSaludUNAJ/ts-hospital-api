using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Entities;

namespace TP_Domain.DTOs
{
    public class ProfesionalConsultorioDto
    {
        public int Id { get; set; }

        //Foreign Keys
        public Consultorio Consultorio { get; set; }
        public Profesional Profesional { get; set; }
    }
}
