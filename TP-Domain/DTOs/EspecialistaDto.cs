using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Entities;

namespace TP_Domain.DTOs
{
    public class EspecialistaDto
    {
        public Guid IdEspecialista { get; set; }

        //Foreign Key
        public Especialidad Especialidad { get; set; }
        public Profesional Profesional { get; set; }
    }
}
