using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class Diagnostico : Chequeo
    {
        public string Receta { get; set; }
        public string Gravedad { get; set; }
        public Anotacion Anotacion { get; set; }  
        
     }
}