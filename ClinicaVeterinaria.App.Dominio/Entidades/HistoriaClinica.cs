using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class HistoriaClinica 
    {
        public Anotacion anotacion { get; set; }
        public Owner  owner { get; set; }
        //public Veterinario veterinario { get; set; }
        //public Auxiliar  auxiliar { get; set; }
    }
}