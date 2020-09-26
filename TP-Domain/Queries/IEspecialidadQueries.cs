using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Entities;

namespace TP_Domain.Queries
{
    public interface IEspecialidadQueries
    {
        Especialidad GetEspecialidadById(int id);
        List<Especialidad> GetAllEspecialidades();
    }

}
