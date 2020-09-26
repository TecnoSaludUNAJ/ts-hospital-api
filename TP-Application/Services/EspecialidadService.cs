using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public class EspecialidadService
    {
        private readonly IGenericRepository _repository;
        
        public EspecialidadService(IGenericRepository repository)
        {
            _repository = repository;
        }
       
        public Especialidad CreateEspecialistaService(EspecialidadDto especialidad)
        {
            var entity = new Especialidad
            {
                Id = especialidad.Id,
                TipoEspecialidad=especialidad.TipoEspecialidad
            };
            _repository.Add<Especialidad>(entity);
            return entity;
        }
    }
}
