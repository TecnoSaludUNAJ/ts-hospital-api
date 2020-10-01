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
        EspecialidadDto CreateEspecialidad(EspecialidadDto especialidad);
        Especialidad GetEspecialidadById(int id);
        List<EspecialidadDto> GetAll();
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
       
        public EspecialidadDto CreateEspecialidad(EspecialidadDto especialidad)
        {
            var entity = new Especialidad
            {
                TipoEspecialidad=especialidad.TipoEspecialidad
            };
            _repository.Add<Especialidad>(entity);

            return new EspecialidadDto
            {
                Id = entity.Id,
                TipoEspecialidad = especialidad.TipoEspecialidad
            };
           
        }

        public Especialidad GetEspecialidadById(int id)
        {
            return _query.GetEspecialidadById(id);
        }

        public List<EspecialidadDto> GetAll()
        {
            return _query.GetAllEspecialidades();
        }
    }
}
