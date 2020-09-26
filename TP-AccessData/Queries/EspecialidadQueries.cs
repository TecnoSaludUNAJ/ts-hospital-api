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
    public class EspecialidadQueries : IEspecialidadQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public EspecialidadQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<Especialidad> GetAllEspecialidades()
        {
            var db=new QueryFactory(connection, sqlKataCompiler);

            //Chequear query
            var query = db.Query("Especialidades").SelectRaw("*").From("Especialidades");

            var result = query.Get<Especialidad>();

            return result.ToList();

        }

        public Especialidad GetEspecialidadById(int id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var especialidad = db.Query("Especialidades").Select("Id", "TipoEspecialidad")
                .Where("Id", "=", id).FirstOrDefault<Especialidad>();

            if (especialidad != null)
            {
                return new Especialidad
                {
                    Id = especialidad.Id,
                    TipoEspecialidad = especialidad.TipoEspecialidad,
                    EspecialistaList = especialidad.EspecialistaList
                };
            }
            else 
            {
                return null;   
            }         
        }
    }
}
