using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public class HospitalService
    {
        private readonly IGenericsRepository _repository;

        public HospitalService(IGenericsRepository repository)
        {
            _repository = repository;
        }
        public Hospital CreateHospital(HospitalDto hospital)
        {
            var entity = new Hospital
            {
                Id = hospital.Id,
                Nombre= hospital.Nombre,
                Direccion= hospital.Direccion,
                Telefono= hospital.Telefono
            };
            _repository.Add<Hospital>(entity);
            return entity;
        }

       
    }
}
