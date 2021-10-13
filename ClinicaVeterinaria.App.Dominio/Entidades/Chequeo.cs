using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{

    public class Chequeo
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        public int ChequeoId { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Pulso { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int PresionArterial { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public String Consiente { get; set;}
        [Required(ErrorMessage = "Campo obligatorio")]
        public String TipoSangre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public String Temperatura { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public String Observaciones { get; set; }
        //public Veterinario veterinario { get; set; }
       // public String Auxiliar { get; set; }
        public Anotacion anotacion { get; set; }
        
    }
}
