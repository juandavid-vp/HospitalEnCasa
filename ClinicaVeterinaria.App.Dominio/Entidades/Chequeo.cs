using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class Chequeo : Mascota
    {
        public int Pulso { get; set; }
        public int PresionArterial { get; set; }
        public Boolean Consiente = true;
        public String TipoSangre { get; set; }
        public float Temperatura { get; set; }
        public String Observaciones { get; set; }


    }
}
