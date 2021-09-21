using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Dueño : Persona
    {
        public string Direccion{get; set;}
        public string Ciudad{get; set;}
        public int EstadoDueño{get; set;}
    }
}