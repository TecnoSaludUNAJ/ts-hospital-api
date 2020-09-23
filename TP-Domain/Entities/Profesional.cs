using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Domain.Entities
{
    public class Profesional
    {
        public Guid IdProfesional { get; set; }
        public int Dni { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }



    }
}
