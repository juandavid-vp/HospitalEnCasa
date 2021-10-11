using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Owner: Persona
    {
        [Required(ErrorMessage ="La direccion es obligatoria")]
        public string Direccion {get; set;}


        [Required(ErrorMessage ="La ciudad es obligatoria")]
        public string Ciudad {get; set;}


        public string EstadoDueño {get; set;}
 
    }
}