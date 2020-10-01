using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Consultorio
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        public List<ProfesionalConsultorio> ProfesionalConsultorioList { get; set; }    
        public int TurnosId { get; set; }
    }
}
