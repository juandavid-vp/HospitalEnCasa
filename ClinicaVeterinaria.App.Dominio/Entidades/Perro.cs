using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Perro : Mascota
    {
        public GeneroMascota Genero {get; set;}
        public string TipoSangreCanino {get; set;}
    }
}