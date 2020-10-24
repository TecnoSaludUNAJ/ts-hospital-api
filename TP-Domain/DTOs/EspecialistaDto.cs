using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Entities;

namespace TP_Domain.DTOs
{
    public class EspecialistaDto
    {
        public int ProfesionalId { get; set; }
        public int EspecialidadId { get; set; }
        public int CalendarioTurnos { get; set; }
    }
}
