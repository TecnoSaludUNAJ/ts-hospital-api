using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_AccessData.Queries
{
    public class ProfesionalQueries:IProfesionalQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public ProfesionalQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public Profesional GetProfesionalById(int id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var profesional = db.Query("Profesionales").Select("Id")
                .Where("Id", "=", id).FirstOrDefault<Profesional>();

            if (profesional != null)
            {
                return profesional;
            }
            else
            {
                return null;
            }
        }
        public List<Profesional> GetAllProfesionales()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Profesionales").SelectRaw("*").From("Profesionales");

            var result = query.Get<Profesional>();

            return result.ToList();
        }
    }
}
