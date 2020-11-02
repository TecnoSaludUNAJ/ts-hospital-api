using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TP_Domain.Entities;

namespace TP_AccessData
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {
        }

        public DbSet<Consultorio> Consultorios { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Especialista> Especialistas { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<HospitalProfesional> HospitalProfesionalList { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<ProfesionalConsultorio> ProfesionalConsultorioList { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.DisplayName());
            }

            builder.Entity<Hospital>().HasData(
            new Hospital
            {
                Id = 1,
                Nombre = "TecnoSaludUNAJ",
                Direccion = "Av. San Martin 2134",
                Telefono = "42574221"
            });

            builder.Entity<Consultorio>().HasData(
                new Consultorio { Id = 1, Numero = 101 }, new Consultorio { Id = 2, Numero = 102 }, new Consultorio { Id = 3, Numero = 103 }
                , new Consultorio { Id = 4, Numero = 104 }, new Consultorio { Id = 5, Numero = 201 }, new Consultorio { Id = 6, Numero = 202 }, new Consultorio { Id = 7, Numero = 203 },
                new Consultorio { Id = 8, Numero = 204 }, new Consultorio { Id = 9, Numero = 301 }, new Consultorio { Id = 10, Numero = 302 }
                ); ;
        }
    }
}
