using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class HistoriaClinica : Anotacion
    {
        public Anotacion anotacion { get; set; }
        public Dueño  Dueño { get; set; }
        //public Veterinario veterinario { get; set; }
        //public Auxiliar  auxiliar { get; set; }
    }
}