using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TP_Domain.DTOs;
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

        public List<EspecialidadDto> GetAllEspecialidades()
        {
            var db=new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Especialidad").SelectRaw("*");

            var result = query.Get<EspecialidadDto>();

            return result.ToList();

        }

        public Especialidad GetEspecialidadById(int id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var especialidad = db.Query("Especialidad").Select("Id", "TipoEspecialidad")
                .Where("Id", "=", id).FirstOrDefault<Especialidad>();
         
                return especialidad;                        
        }      
    }
}
