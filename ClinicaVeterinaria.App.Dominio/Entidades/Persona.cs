using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Persona
    {
        public int Id{get; set;}
        public string Nombre{get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string NumeroTelefono {get; set;}
        public string CorreoElectronico {get; set;}
        
    }

}