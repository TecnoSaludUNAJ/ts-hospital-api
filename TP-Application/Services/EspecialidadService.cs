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
        ResponseEspecialidad CreateEspecialidad(EspecialidadDto especialidad);
        ResponseEspecialidad GetById(int id);
        List<ResponseEspecialidad> GetAll();
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
       
        public ResponseEspecialidad CreateEspecialidad(EspecialidadDto especialidad)
        {
            var entity = new Especialidad
            {
                TipoEspecialidad=especialidad.TipoEspecialidad
            };
            _repository.Add<Especialidad>(entity);

            return new ResponseEspecialidad
            {
                Id = entity.Id,
                TipoEspecialidad = especialidad.TipoEspecialidad
            };
           
        }

        public ResponseEspecialidad GetById(int id)
        {
            return _query.GetEspecialidadById(id);
        }

        public List<ResponseEspecialidad> GetAll()
        {
            return _query.GetAllEspecialidades();
        }
    }
}
