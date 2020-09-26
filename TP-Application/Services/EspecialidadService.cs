using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{
    public class EspecialidadService
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
                Id = especialidad.Id,
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
    }
}
