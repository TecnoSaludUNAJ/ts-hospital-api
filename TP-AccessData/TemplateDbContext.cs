using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
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

    }
}
