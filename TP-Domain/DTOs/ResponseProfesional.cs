using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Domain.DTOs
{
    public class ResponseProfesional
    {
        public int EspecialidadId { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
