using System.Collections.Generic;
using TP_Domain.DTOs;

namespace TP_Domain.Queries
{
    public interface IEspecialidadQueries
    {
        ResponseEspecialidad GetEspecialidadById(int id);
        List<ResponseEspecialidad> GetAllEspecialidades();
    }

}
