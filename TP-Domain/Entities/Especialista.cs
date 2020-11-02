﻿namespace TP_Domain.Entities
{
    public class Especialista
    {
        public int Id { get; set; }

        //Foreign Key
        public Especialidad Especialidad { get; set; }
        public int EspecialidadId { get; set; }

        public Profesional Profesional { get; set; }
        public int ProfesionalId { get; set; }

        public int CalendarioTurnos { get; set; }

    }
}
