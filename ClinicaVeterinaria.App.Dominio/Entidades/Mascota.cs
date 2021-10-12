using System;
//using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Mascota 
    {
        public int MascotaId { get; set; }
       // [Required(ErrorMessage = "El Nombre es un campo obligatorio")]
        public string NombreM {get; set;}
        //[Required(ErrorMessage = "El Peso es un campo obligatorio")]
        public float Peso { get; set; }
       // [Required(ErrorMessage = "El Nacimiento es un campo obligatorio")]
        public DateTime Nacimiento { get; set;}
       // [Required(ErrorMessage = "La Especie es un campo obligatorio")]
        public String Especie { get; set; }
       // [Required(ErrorMessage = "El Color es un campo obligatorio")]
        public String Color { get; set; }
        //[Required(ErrorMessage = "La Descripción es un campo obligatorio")]
        public String Descripción { get; set; }
        public string Password { get; set; }
        public Owner  owner { get; set; }      
        public Auxiliar auxiliar { get; set; }
        public Veterinario veterinario { get; set; }  

    }
}