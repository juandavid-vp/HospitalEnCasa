using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{

    public class Diagnostico 
    {
      public int DiagnosticoId { get; set; }
      [Required(ErrorMessage = "Campo obligatorio")]
      public string Receta { get; set; }
      [Required(ErrorMessage = "Campo obligatorio")]
      public string Gravedad { get; set; }
      [Required(ErrorMessage = "Campo obligatorio")]
      public Mascota mascota { get; set; }
      public Anotacion anotacion { get; set; }
      public Chequeo  chequeo { get; set; }
      
        
     }
}