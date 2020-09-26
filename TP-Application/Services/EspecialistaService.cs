using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public class EspecialistaService
    {
        private readonly IGenericRepository _repository;

        public EspecialistaService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public Especialista CreateEspecialistaService(EspecialistaDto especialista)
        {
            var entity = new Especialista
            {
                Id = especialista.Id,
                Especialidad=especialista.Especialidad,
                Profesional=especialista.Profesional
            };      
            _repository.Add<Especialista>(entity);         
            return entity;
        }
    }
}
