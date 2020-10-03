using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Domain.DTOs
{
    public class ProfesionalDto
    {
        public int Dni { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
