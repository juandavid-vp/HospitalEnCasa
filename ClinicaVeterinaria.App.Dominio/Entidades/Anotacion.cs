using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Anotacion 
    {
        public int AnotacionId { get; set;}
        public int Duracion { get; set; }
        public DateTime FechaHora { get; set; }
        public Owner owner { get; set; }
        public Mascota mascota { get; set; }
        public Veterinario veterinario { get; set; }
        public Auxiliar auxiliar { get; set; }
        
        //public Chequeo chequeo { get; set; }        
        //public Mascota mascota { get; set; }    
    }
}
