namespace TP_Domain.Entities
{
    public class ProfesionalConsultorio
    {
        public int Id { get; set; }

        //Foreign Keys
        public Consultorio Consultorio { get; set; }
        public int ConsultorioId { get; set; }
        public Profesional Profesional { get; set; }
        public int ProfesionalId { get; set; }



    }
}
