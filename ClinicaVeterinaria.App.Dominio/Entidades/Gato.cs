using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Gato : Mascota
    {
        public GeneroMascota Genero {get; set;}
        public string TipoSangreMinino {get; set;}
    }
}