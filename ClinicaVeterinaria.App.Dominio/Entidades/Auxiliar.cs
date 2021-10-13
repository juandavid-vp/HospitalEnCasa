using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Auxiliar : Persona
    {
        [Required(ErrorMessage = "El Horario Laboral es un campo obligatorio")]
        public DateTime HorarioLaboral{get; set;}
        [Required(ErrorMessage = "La Licencia Profesional es un campo obligatorio")]
        public string LicenciaProfesional{get; set;}
        [Required(ErrorMessage = "La Especializacion es un campo obligatorio")]
        public string Especializacion{get; set;}
        [Required(ErrorMessage = "El Estado Veterinario es un campo obligatorio")]
        public int EstadoVeterinario{get; set;}
    }
}