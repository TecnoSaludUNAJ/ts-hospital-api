using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public class ConsultorioService
    {
        private readonly IGenericRepository _repository;

        public ConsultorioService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public Consultorio CreateEspecialistaService(ConsultorioDto consultorio)
        {
            var entity = new Consultorio
            {
                Id = consultorio.Id,             
            };
            _repository.Add<Consultorio>(entity);
            return entity;
        }
    }
}
