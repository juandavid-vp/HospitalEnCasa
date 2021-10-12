using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Agenda 
    {
        public int AgendaId { get; set; }
        public Veterinario Veterinario { get; set; }
        public Auxiliar Auxiliar { get; set; }
        public String Descripcion { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
    }
}