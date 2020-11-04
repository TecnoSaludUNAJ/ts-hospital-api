using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_AccessData.Migrations
{
    public partial class mshospitalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultorio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(nullable: false),
                    TurnosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEspecialidad = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesional",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dni = table.Column<string>(nullable: false),
                    Matricula = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    Domicilio = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialidadId = table.Column<int>(nullable: false),
                    ProfesionalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Especialista_Especialidad_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Especialista_Profesional_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalProfesional",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalId = table.Column<int>(nullable: false),
                    ProfesionalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalProfesional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalProfesional_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalProfesional_Profesional_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfesionalConsultorio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultorioId = table.Column<int>(nullable: false),
                    ProfesionalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesionalConsultorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfesionalConsultorio_Consultorio_ConsultorioId",
                        column: x => x.ConsultorioId,
                        principalTable: "Consultorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesionalConsultorio_Profesional_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Consultorio",
                columns: new[] { "Id", "Numero", "TurnosId" },
                values: new object[,]
                {
                    { 1, 101, 0 },
                    { 2, 102, 0 },
                    { 3, 103, 0 },
                    { 4, 104, 0 },
                    { 5, 201, 0 },
                    { 6, 202, 0 },
                    { 7, 203, 0 },
                    { 8, 204, 0 },
                    { 9, 301, 0 },
                    { 10, 302, 0 }
                });

            migrationBuilder.InsertData(
                table: "Hospital",
                columns: new[] { "Id", "Direccion", "Nombre", "Telefono" },
                values: new object[] { 1, "Av. San Martin 2134", "TecnoSaludUNAJ", "42574221" });

            migrationBuilder.CreateIndex(
                name: "IX_Especialista_EspecialidadId",
                table: "Especialista",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Especialista_ProfesionalId",
                table: "Especialista",
                column: "ProfesionalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalProfesional_HospitalId",
                table: "HospitalProfesional",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalProfesional_ProfesionalId",
                table: "HospitalProfesional",
                column: "ProfesionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesionalConsultorio_ConsultorioId",
                table: "ProfesionalConsultorio",
                column: "ConsultorioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesionalConsultorio_ProfesionalId",
                table: "ProfesionalConsultorio",
                column: "ProfesionalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialista");

            migrationBuilder.DropTable(
                name: "HospitalProfesional");

            migrationBuilder.DropTable(
                name: "ProfesionalConsultorio");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "Consultorio");

            migrationBuilder.DropTable(
                name: "Profesional");
        }
    }
}
