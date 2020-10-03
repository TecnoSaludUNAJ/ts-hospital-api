using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Profesional
    {
        public int Id { get; set; }
        [Required] public int Dni { get; set; }
        [Required] public string Matricula { get; set; }
        [Required] public string Nombre { get; set; }
        [Required] public string Apellido { get; set; }
        [Required] public DateTime FechaNacimiento { get; set; }
        [Required] public string Sexo { get; set; }
        [Required] public string Domicilio { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Telefono { get; set; }

        public List<ProfesionalConsultorio> ProfesionalConsultorioNavigator { get; set; }
        public List<HospitalProfesional> HospitalProfesionalNavigator { get; set; }
        public List<Especialista> EspecialistaNavigator { get; set; }
    }
}
