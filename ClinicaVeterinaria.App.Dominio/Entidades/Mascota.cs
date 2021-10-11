using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Mascota 
    {
        public int MascotaId { get; set; }
        public string NombreM {get; set;}
        public float Peso { get; set; }
        public DateTime Nacimiento { get; set;}
        public String Especie { get; set; }
        public String Color { get; set; }
        public String Descripción { get; set; }
        //public Owner  owner { get; set; }
        

    }
}