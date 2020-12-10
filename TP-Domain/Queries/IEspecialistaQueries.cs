using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.DTOs;

namespace TP_Domain.Queries
{
    public interface IEspecialistaQueries
    {
        EspecialistaDto GetById(int id);
        List<EspecialistaInfoDto> GetAll();
    }
}
