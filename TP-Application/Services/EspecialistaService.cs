using System.Collections.Generic;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{

    public interface IEspecialistaService
    {
        EspecialistaDto CreateEspecialista(EspecialistaDto especialista);
        EspecialistaDto GetById(int id);
        List<EspecialistaDto> GetAll();
    }

    public class EspecialistaService : IEspecialistaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IEspecialidadQueries _queryEspecialidad;
        private readonly IProfesionalQueries _queryProfesional;
        private readonly IEspecialistaQueries _queryEspecialista;

        public EspecialistaService(IGenericsRepository repository, IEspecialidadQueries queryEspecialidad, IProfesionalQueries queryProfesional,IEspecialistaQueries queryEspecialista)
        {
            _repository = repository;
            _queryEspecialidad = queryEspecialidad;
            _queryProfesional = queryProfesional;
            _queryEspecialista = queryEspecialista;
        }

        public EspecialistaDto CreateEspecialista(EspecialistaDto especialista)
        {

            Especialista esp = new Especialista
            {
                EspecialidadId = especialista.EspecialidadId,
                ProfesionalId = especialista.ProfesionalId
            };
            _repository.Add<Especialista>(esp);
            return new EspecialistaDto
            {
               Id=esp.Id,
                EspecialidadId = esp.EspecialidadId,
                ProfesionalId = esp.ProfesionalId
            };
        }

        public List<EspecialistaDto> GetAll()
        {
            return _queryEspecialista.GetAll();
        }

        public EspecialistaDto GetById(int id)
        {
            return _queryEspecialista.GetById(id);
        }

        
    }
}
