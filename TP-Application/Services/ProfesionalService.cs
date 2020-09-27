using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{
    public interface IProfesionalService
    {
        Profesional CreateProfesional(ProfesionalDTO profesional);
        Profesional GetProfesionalById(int id);
        List<Profesional> GetAllProfesionales();
    }      
    
    public class ProfesionalService:IProfesionalService
    {
        private readonly IGenericsRepository _repository;
        private readonly IProfesionalQueries _query;

        public ProfesionalService(IGenericsRepository repository, IProfesionalQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public Profesional CreateProfesional(ProfesionalDTO profesional)
        {
            var entity = new Profesional
            {
                Dni=profesional.Dni,
                Matricula=profesional.Matricula,
                Nombre = profesional.Nombre,
                Apellido = profesional.Apellido,
                FechaNacimiento = profesional.FechaNacimiento,
                Sexo = profesional.Sexo,
                Domicilio = profesional.Domicilio,
                Email = profesional.Email,
                Telefono = profesional.Telefono

            };
            _repository.Add<Profesional>(entity);
            return entity;
        }     

        public List<Profesional> GetAllProfesionales()
        {
            return _query.GetAllProfesionales();
        }

        public Profesional GetProfesionalById(int id)
        {
            return _query.GetProfesionalById(id);
        }
    }
}
