using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public class ProfesionalConsultorioService
    {
        private readonly IGenericRepository _repository;

        public ProfesionalConsultorioService(IGenericRepository repository)
        {
            _repository = repository;
        }
        public ProfesionalConsultorio CreateEspecialistaService(ProfesionalConsultorioDto profesionalconsultorio)
        {
            var entity = new ProfesionalConsultorio
            {
                Id = profesionalconsultorio.Id,
                Profesional= profesionalconsultorio.Profesional,
                Consultorio= profesionalconsultorio.Consultorio
            };
            _repository.Add<ProfesionalConsultorio>(entity);
            return entity;
        }
    }
}
