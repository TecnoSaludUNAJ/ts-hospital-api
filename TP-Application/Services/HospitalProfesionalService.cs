using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public class HospitalProfesionalService
    {
        private readonly IGenericRepository _repository;

        public HospitalProfesionalService(IGenericRepository repository)
        {
            _repository = repository;
        }
        public HospitalProfesional CreateEspecialistaService(HospitalProfesionalDto hospitalprofesional)
        {
            var entity = new HospitalProfesional
            {
                Id = hospitalprofesional.Id,
                Hospital= hospitalprofesional.Hospital,
                Profesional= hospitalprofesional.Profesional
            };
            _repository.Add<HospitalProfesional>(entity);
            return entity;
        }
    }
}
