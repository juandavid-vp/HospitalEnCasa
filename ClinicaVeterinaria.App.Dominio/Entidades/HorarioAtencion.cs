using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class HorarioAtencion
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public Veterinario veterinario { get; set; }
        public Auxiliar auxiliar { get; set; }

    }

}