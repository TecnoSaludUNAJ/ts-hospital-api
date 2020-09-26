using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class ProfesionalConsultorio
    {
        public int Id { get; set; }     

        //Foreign Keys
        public Consultorio Consultorio { get; set; }
        public Profesional Profesional { get; set; }



    }
}
