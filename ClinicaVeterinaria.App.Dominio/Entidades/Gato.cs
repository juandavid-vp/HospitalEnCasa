using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Gato : Mascota
    {
        public Gato(GeneroMascota genero) 
        {
            this.Genero = genero;
   
        }
                public GeneroMascota Genero {get; set;}
    }
}