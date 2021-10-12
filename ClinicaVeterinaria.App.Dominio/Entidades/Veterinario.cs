using System;
//using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Veterinario : Persona
    {
        public DateTime HorarioLaboral{get; set;}
        //[Required(ErrorMessage = "La licencia Profesional es un campo obligatorio")]
        public string LicenciaProfesional{get; set;}
        //[Required(ErrorMessage = "La Especializacion es un campo obligatorio")]
        public string Especializacion{get; set;}
        //[Required(ErrorMessage = "El Estado Veterinario es un campo obligatorio Activo o Inactivo")]
        public int EstadoVeterinario{get; set;}
                
    }

}