using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Domain.DTOs
{
    public class ResponseProfesionalAndEspecialidades
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string matricula { get; set; }
        public int usuarioId { get; set; }
        public List<ResponseEspecialidad> especialidades { get; set; }
    }
}
