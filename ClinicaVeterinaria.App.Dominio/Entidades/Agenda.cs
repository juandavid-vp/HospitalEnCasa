using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Agenda 
    {
        [Key]
        public int AgendaId { get; set; }
        public Veterinario Veterinario { get; set; }
        public Auxiliar Auxiliar { get; set; }
        public Mascota Mascota { get; set; }
        [Required]
        public String Descripcion { get; set; }
        [Required(ErrorMessage = "El día es obligatorio."),DataType(DataType.Date),Range(typeof(DateTime), "1/1/2021", "31/12/2025",
        ErrorMessage = "El valor {0} debe estar {1} y {2}")]
        public DateTime Dia { get; set; }
       
         [Required(ErrorMessage = "La hora es obligatoria."),DataType(DataType.Time)]
        public DateTime Hora { get; set; }
    }
}