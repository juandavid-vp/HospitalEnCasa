using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Anotacion : HorarioAtencion 
    {
        public int IdAnotacion { get; set; }
        public Dueño dueño { get; set; }
        public Veterinario Veterinario { get; set; }
        public Auxiliar Auxiliar { get; set; }
        public Veterinario veterinario { get; set; }
        public int Duracion { get; set; }
        public Chequeo chequeo { get; set; }        
    }
}
