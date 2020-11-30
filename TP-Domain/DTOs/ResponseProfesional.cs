namespace TP_Domain.DTOs
{
    public class ResponseProfesional
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int UsuarioId { get; set; }
    }
}
