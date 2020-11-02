using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{

    public interface IEspecialistaService
    {
        EspecialistaDto CreateEspecialista(EspecialistaDto especialista);
    }

    public class EspecialistaService : IEspecialistaService
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

        public EspecialistaDto CreateEspecialista(EspecialistaDto especialista)
        {

            Especialista esp = new Especialista
            {
                EspecialidadId = especialista.EspecialidadId,
                ProfesionalId = especialista.ProfesionalId,
                CalendarioTurnos = especialista.CalendarioTurnos
            };
            _repository.Add<Especialista>(esp);
            return new EspecialistaDto
            {
                EspecialidadId = esp.EspecialidadId,
                ProfesionalId = esp.ProfesionalId,
                CalendarioTurnos = esp.CalendarioTurnos
            };
        }

    }
}
