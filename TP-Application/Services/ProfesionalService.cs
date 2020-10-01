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
        ResponseProfesional CreateProfesional(ProfesionalDto profesional);
        Profesional GetProfesionalById(int id);
        List<ProfesionalDto> GetAll(int IdEspecialidad);
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

        public ResponseProfesional CreateProfesional(ProfesionalDto profesional)
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
          
            return new ResponseProfesional
            {                 
                Matricula=profesional.Matricula,
                Nombre=profesional.Nombre,
                Apellido=profesional.Apellido      
            };
        }     

        public List<ProfesionalDto> GetAll(int IdEspecialidad)
        {
            return _query.GetAllProfesionales(IdEspecialidad);
        }

        public Profesional GetProfesionalById(int id)
        {
            return _query.GetProfesionalById(id);
        }
    }
}
