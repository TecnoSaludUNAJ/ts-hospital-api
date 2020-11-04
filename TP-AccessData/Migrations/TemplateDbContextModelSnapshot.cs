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

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("TurnosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Consultorio");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Numero = 101,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 2,
                            Numero = 102,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 3,
                            Numero = 103,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 4,
                            Numero = 104,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 5,
                            Numero = 201,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 6,
                            Numero = 202,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 7,
                            Numero = 203,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 8,
                            Numero = 204,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 9,
                            Numero = 301,
                            TurnosId = 0
                        },
                        new
                        {
                            Id = 10,
                            Numero = 302,
                            TurnosId = 0
                        });
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

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("TP_Domain.Entities.Especialista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesionalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("Especialista");
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

                    b.ToTable("Hospital");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "Av. San Martin 2134",
                            Nombre = "TecnoSaludUNAJ",
                            Telefono = "42574221"
                        });
                });

            modelBuilder.Entity("TP_Domain.Entities.HospitalProfesional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesionalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("HospitalProfesional");
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

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Profesional");
                });

            modelBuilder.Entity("TP_Domain.Entities.ProfesionalConsultorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConsultorioId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesionalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultorioId");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("ProfesionalConsultorio");
                });

            modelBuilder.Entity("TP_Domain.Entities.Especialista", b =>
                {
                    b.HasOne("TP_Domain.Entities.Especialidad", "Especialidad")
                        .WithMany("EspecialistaNavigator")
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_Domain.Entities.Profesional", "Profesional")
                        .WithMany("EspecialistaNavigator")
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Domain.Entities.HospitalProfesional", b =>
                {
                    b.HasOne("TP_Domain.Entities.Hospital", "Hospital")
                        .WithMany("HospitalProfesionalNavigator")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_Domain.Entities.Profesional", "Profesional")
                        .WithMany("HospitalProfesionalNavigator")
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Domain.Entities.ProfesionalConsultorio", b =>
                {
                    b.HasOne("TP_Domain.Entities.Consultorio", "Consultorio")
                        .WithMany("ProfesionalConsultorioList")
                        .HasForeignKey("ConsultorioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_Domain.Entities.Profesional", "Profesional")
                        .WithMany("ProfesionalConsultorioNavigator")
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
