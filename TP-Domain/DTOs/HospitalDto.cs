using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Domain.DTOs
{
    public class HospitalDto
    {
        public Guid IdHospital { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
