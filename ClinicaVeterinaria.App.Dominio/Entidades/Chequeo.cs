using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class Chequeo : Mascota
    {
        public int Pulso { get; set; }
        public int PresionArterial { get; set; }
        public Boolean Consiente = true;
        public String TipoSangre { get; set; }
        public String Temperatura { get; set; }
        public String Observaciones { get; set; }
        //public Veterinario veterinario { get; set; }
        public String Auxiliar { get; set; }
        public Anotacion anotacion { get; set; }
        
    }
}
