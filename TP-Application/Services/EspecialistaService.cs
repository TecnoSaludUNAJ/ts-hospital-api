﻿using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using System.Linq;
using TP_Domain.Queries;
using System.Collections;
using System.Collections.Generic;

namespace TP_Application.Services
{

    public interface IEspecialistaService
    {
        Especialista CreateEspecialista(EspecialistaDto especialista);
    }
    
    public class EspecialistaService:IEspecialistaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IEspecialidadQueries _queryEspecialidad;
        private readonly IProfesionalQueries _queryProfesional;

        public EspecialistaService(IGenericsRepository repository, IEspecialidadQueries queryEspecialidad, IProfesionalQueries queryProfesional)
        {
            _repository = repository;
            _queryEspecialidad = queryEspecialidad;
            _queryProfesional = queryProfesional;
        }

        public Especialista CreateEspecialista(EspecialistaDto especialista)
        {

            Especialista esp = new Especialista
            {
                EspecialidadId = especialista.EspecialidadId,
                ProfesionalId = especialista.ProfesionalId
            };
            _repository.Add<Especialista>(esp);
            return esp;
        }
       
    }
}
