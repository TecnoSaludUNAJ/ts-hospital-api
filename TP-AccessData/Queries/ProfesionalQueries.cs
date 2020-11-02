using SqlKata.Compilers;
using SqlKata.Execution;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TP_Domain.DTOs;
using TP_Domain.Queries;

namespace TP_AccessData.Queries
{
    public class ProfesionalQueries : IProfesionalQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public ProfesionalQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public ResponseProfesional GetProfesionalById(int id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var profesional = db.Query("Profesional")
            .Where("Id", "=", id).FirstOrDefault<ResponseProfesional>();

            if (profesional != null){return profesional;}
            else{return null;}
        }
        public List<ResponseProfesional> GetAllProfesionales(int IdEspecialidad)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            if (IdEspecialidad == 0)
            {
                var query = db.Query("Profesional");
                var result = query.Get<ResponseProfesional>();
                return result.ToList();
            }

            else
            {
                var query = db.Query("Profesional")                 
                    .Join("Especialista", "Profesional.Id", "Especialista.ProfesionalId")
                    .Join("Especialidad", "Especialidad.Id", "Especialista.EspecialidadId")
                    .Where("Especialista.EspecialidadId", "=", IdEspecialidad);

                var result = query.Get<ResponseProfesional>();
                return result.ToList();
            }

        }
    }
}
