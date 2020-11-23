using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TP_Domain.DTOs;
using TP_Domain.Queries;

namespace TP_AccessData.Queries
{
    public class EspecialistaQueries:IEspecialistaQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public EspecialistaQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public EspecialistaDto GetById(int id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var especialista = db.Query("Especialista")
                .Join("Profesional", "Especialista.ProfesionalId", "Profesional.Id")
                .Join("Especialidad", "Especialista.EspecialidadId", "Especialidad.Id")
                .Where("Especialista.Id", "=", id).FirstOrDefault<EspecialistaDto>();

            return especialista;
        }

        public List<EspecialistaDto> GetAll()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Especialista")
                .Join("Profesional", "Especialista.ProfesionalId", "Profesional.Id")
                .Join("Especialidad", "Especialista.EspecialidadId", "Especialidad.Id");

            var result = query.Get<EspecialistaDto>();

            return result.ToList();

        }


    }
}
