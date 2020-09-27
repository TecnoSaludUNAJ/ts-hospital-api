﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_AccessData;

namespace TP_AccessData.Migrations
{
    [DbContext(typeof(TemplateDbContext))]
    partial class TemplateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TP_Domain.Entities.Consultorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Consultorios");
                });

            modelBuilder.Entity("TP_Domain.Entities.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoEspecialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("TP_Domain.Entities.Especialista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesionalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("Especialistas");
                });

            modelBuilder.Entity("TP_Domain.Entities.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospitales");
                });

            modelBuilder.Entity("TP_Domain.Entities.HospitalProfesional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesionalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("HospitalProfesionalList");
                });

            modelBuilder.Entity("TP_Domain.Entities.Profesional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesionales");
                });

            modelBuilder.Entity("TP_Domain.Entities.ProfesionalConsultorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConsultorioId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesionalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultorioId");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("ProfesionalConsultorioList");
                });

            modelBuilder.Entity("TP_Domain.Entities.Especialista", b =>
                {
                    b.HasOne("TP_Domain.Entities.Especialidad", "Especialidad")
                        .WithMany("EspecialistaList")
                        .HasForeignKey("EspecialidadId");

                    b.HasOne("TP_Domain.Entities.Profesional", "Profesional")
                        .WithMany("EspecialistaList")
                        .HasForeignKey("ProfesionalId");
                });

            modelBuilder.Entity("TP_Domain.Entities.HospitalProfesional", b =>
                {
                    b.HasOne("TP_Domain.Entities.Hospital", "Hospital")
                        .WithMany("HospitalProfesionalList")
                        .HasForeignKey("HospitalId");

                    b.HasOne("TP_Domain.Entities.Profesional", "Profesional")
                        .WithMany("HospitalProfesionalList")
                        .HasForeignKey("ProfesionalId");
                });

            modelBuilder.Entity("TP_Domain.Entities.ProfesionalConsultorio", b =>
                {
                    b.HasOne("TP_Domain.Entities.Consultorio", "Consultorio")
                        .WithMany("ProfesionalConsultorioList")
                        .HasForeignKey("ConsultorioId");

                    b.HasOne("TP_Domain.Entities.Profesional", "Profesional")
                        .WithMany("ProfesionalConsultorioList")
                        .HasForeignKey("ProfesionalId");
                });
#pragma warning restore 612, 618
        }
    }
}