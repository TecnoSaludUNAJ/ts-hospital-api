using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public class ProfesionalService
    {
        private readonly IGenericRepository _repository;

        public ProfesionalService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public Profesional CreateEspecialistaService(ProfesionalDTO profesional)
        {
            var entity = new Profesional
            {
                Id = profesional.Id,
                Dni=profesional.Dni,
                Matricula=profesional.Matricula,
                Nombre = profesional.Nombre,
                Apellido = profesional.Apellido,
                FechaNacimiento = profesional.FechaNacimiento,
                Sexo = profesional.Sexo,
                Domicilio = profesional.Domicilio,
                Email = profesional.Email,
                Telefono = profesional.Telefono

            };
            _repository.Add<Profesional>(entity);
            return entity;
        }
    }
}
