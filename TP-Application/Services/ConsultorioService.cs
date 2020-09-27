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
        private readonly IGenericsRepository _repository;

        public ConsultorioService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Consultorio CreateConsultorio(ConsultorioDto consultorio)
        {
            var entity = new Consultorio
            {
                Id = consultorio.Id,
               Numero=consultorio.Numero
    };
            _repository.Add<Consultorio>(entity);
            return entity;
        }
    }
}
