using System.Collections.Generic;
using TP_Domain.DTOs;

namespace TP_Domain.Queries
{
    public interface IProfesionalQueries
    {
        ResponseProfesional GetProfesionalById(int id);
        List<ResponseProfesional> GetAllProfesionales(int IdEspecialidad, int usuarioId);

        ResponseProfesionalAndEspecialidades GetProfesionalAndEspecialidades(int usuarioid);
    }
}
