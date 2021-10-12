using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Persona
    {
        public int Id{get; set;}

       // [Required(ErrorMessage = "El nombre es un campo obligatorio")]
        public string Nombre{get; set;}
       // [Required(ErrorMessage = "La cedula es un campo obligatorio")]
        public int Cedula{get; set;}
       // [Required(ErrorMessage = "El Fecha de Nacimiento es un campo obligatorio")]
        public DateTime FechaNacimiento {get; set;}
        //[Required(ErrorMessage = "El NumeroTelefono es un campo obligatorio")]
        public string NumeroTelefono {get; set;}
        public string CorreoElectronico {get; set;}
        //[Required(ErrorMessage = "El nombre de usuario es requerido."),RegularExpression(@"^\S*$", ErrorMessage = "No se permiten espacios")]
        public string Username { get; set; }
        //[Required(ErrorMessage = "La contraseña es requerida."),DataType(DataType.Password),StringLength(100,MinimumLength=6,ErrorMessage="La contraseña debe tener entre 6 y 100 carácteres")]
        public string Password { get; set; }
    }

}
