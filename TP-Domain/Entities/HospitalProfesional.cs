using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class HospitalProfesional
    {
        public int Id { get; set; }

        //Foreign Key
        public Hospital Hospital { get; set; }
        public int HospitalId { get; set; }
        public Profesional Profesional { get; set; }
        public int ProfesionalId { get; set; }
    }
}
