using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{
    public interface IEspecialidadService
    {
        Especialidad CreateEspecialidad(EspecialidadDto especialidad);
        Especialidad GetEspecialidadById(int id);
        List<Especialidad> GetAllEspecialidades();
        List<Especialista> GetEspecialistasByEspecialidad(int id);
    }
    
    
    public class EspecialidadService:IEspecialidadService
    {
        private readonly IGenericsRepository _repository;
        private readonly IEspecialidadQueries _query;

        public EspecialidadService(IGenericsRepository repository, IEspecialidadQueries query)
        {
            _repository = repository;
            _query = query;
        }
       
        public Especialidad CreateEspecialidad(EspecialidadDto especialidad)
        {
            var entity = new Especialidad
            {
                TipoEspecialidad=especialidad.TipoEspecialidad
            };
            _repository.Add<Especialidad>(entity);
            return entity;
        }

        public Especialidad GetEspecialidadById(int id)
        {
            return _query.GetEspecialidadById(id);
        }

        public List<Especialidad> GetAllEspecialidades()
        {
            return _query.GetAllEspecialidades();
        }

        public List<Especialista> GetEspecialistasByEspecialidad(int id)
        {
            return _query.GetEspecialistasByEspecialidad(id);   
        }


    }
}
