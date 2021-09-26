using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Mascota
    {
        public int Id{get; set;}
        public string Nombre{get; set;}
        public GeneroMascota Genero{get; set;} 
    }
}