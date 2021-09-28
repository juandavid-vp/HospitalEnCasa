using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Mascota :Dueño
    {
        public int Id{get; set;}
        public string Nombre{get; set;}
        public float Peso { get; set; }
        public DateTime Nacimiento { get; set;}
        public String Especie { get; set; }
        public String Color { get; set; }
        public String Descripción { get; set; }
    }
}