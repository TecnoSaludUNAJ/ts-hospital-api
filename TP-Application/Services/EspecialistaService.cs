using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using System.Linq;
using TP_Domain.Queries;

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

            Especialidad especialidad = _queryEspecialidad.GetEspecialidadById(especialista.EspecialidadId);
            Profesional profesional = _queryProfesional.GetProfesionalById(especialista.ProfesionalId);

            var entity = new Especialista
            {
                Profesional = profesional,
                Especialidad = especialidad,
                CalendarioTurnos = 64,
                Id = especialidad.Id
            };
            _repository.Add<Especialista>(entity);
            return entity;
        }
    }
}
