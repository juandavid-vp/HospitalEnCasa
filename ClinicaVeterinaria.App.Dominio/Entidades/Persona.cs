using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Persona {

        [Required(ErrorMessage ="La cedula es obligatoria"),Range(0,int.MaxValue,ErrorMessage="La cedula debe ser mayor que 0")]
        public int Id{get; set;}


        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre{get; set;}


        [Required(ErrorMessage ="La Fecha de nacimiento es obligatoria")]
        public DateTime FechaNacimiento {get; set;}


        [Required(ErrorMessage ="El numero de telefono es obligatorio"),RegularExpression(@"^\S*$",ErrorMessage = "No se permiten espacios o caracteres especiales")]
        public string NumeroTelefono {get; set;}


        [Required(ErrorMessage ="El correo electronico obligatorio"),EmailAddress(ErrorMessage = "El dato debe ser un email")]
        public string CorreoElectronico {get; set;}


        public int NumeroIdentificacion {get; set;}


        [Required(ErrorMessage = "El nickname es requerido."),RegularExpression(@"^\S*$", ErrorMessage = "No se permiten espacios")]
        public string UserName {get; set;}
       
        
        [Required(ErrorMessage = "La contraseña es requerida."),DataType(DataType.Password),StringLength(16,MinimumLength=8,ErrorMessage="La contraseña debe tener entre 8 y 16 carácteres")]
        public string PassWord {get; set;}
    }    
}    