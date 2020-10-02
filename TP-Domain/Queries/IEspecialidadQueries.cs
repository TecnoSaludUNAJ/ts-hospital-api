using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Domain.Queries
{
    public interface IEspecialidadQueries
    {
        ResponseEspecialidad GetEspecialidadById(int id);
        List<ResponseEspecialidad> GetAllEspecialidades();       
    }

}
