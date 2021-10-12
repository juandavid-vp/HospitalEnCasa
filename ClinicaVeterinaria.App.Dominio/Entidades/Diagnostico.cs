using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class Diagnostico 
    {
      public int DiagnosticoId { get; set; }
      public string Receta { get; set; }
      public string Gravedad { get; set; }
      public Mascota mascota { get; set; }
      public Anotacion anotacion { get; set; }
      public Chequeo  chequeo { get; set; }
      
        
     }
}