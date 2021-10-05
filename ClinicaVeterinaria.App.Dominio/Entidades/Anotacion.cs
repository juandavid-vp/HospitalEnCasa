using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Anotacion 
    {
        public int AnotacionId { get; set;}
        public Owner owner { get; set; }
       // public Veterinario Veterinario { get; set; }
       // public Auxiliar Auxiliar { get; set; }
        public int Duracion { get; set; }
        //public Chequeo chequeo { get; set; }        
        //public Mascota mascota { get; set; }    
    }
}
