﻿using SqlKata.Compilers;
using SqlKata.Execution;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TP_Domain.DTOs;
using TP_Domain.Queries;


namespace TP_AccessData.Queries
{
    public class EspecialidadQueries : IEspecialidadQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public EspecialidadQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<ResponseEspecialidad> GetAllEspecialidades()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Especialidad");

            var result = query.Get<ResponseEspecialidad>();

            return result.ToList();

        }

        public ResponseEspecialidad GetEspecialidadById(int id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var especialidad = db.Query("Especialidad").Select("Id", "TipoEspecialidad")
                .Where("Id", "=", id).FirstOrDefault<ResponseEspecialidad>();

            return especialidad;
        }
    }
}
