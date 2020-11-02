using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP_Domain.Entities
{
    public class Especialidad
    {
        public int Id { get; set; }
        [Required] public string TipoEspecialidad { get; set; }

        public List<Especialista> EspecialistaNavigator { get; set; }

    }
}
