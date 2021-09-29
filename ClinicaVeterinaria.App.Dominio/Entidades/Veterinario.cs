using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Veterinario : Persona
    {
        public DateTime HorarioLaboral{get; set;}
        public string LicenciaProfesional{get; set;}
        public string EstadoVeterinario{get; set;}
    }


}