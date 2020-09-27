using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Entities;

namespace TP_Domain.Queries
{
    public interface IProfesionalQueries
    {
        Profesional GetProfesionalById(int id);
        List<Profesional> GetAllProfesionales();
    }
}
