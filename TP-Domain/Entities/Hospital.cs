using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Hospital
    {
        public int Id { get; set; }
        [Required] public string Nombre { get; set; }
        [Required] public string Direccion { get; set; }
        [Required] public string Telefono { get; set; }

        public List<HospitalProfesional> HospitalProfesionalNavigator { get; set; }
    }
}
