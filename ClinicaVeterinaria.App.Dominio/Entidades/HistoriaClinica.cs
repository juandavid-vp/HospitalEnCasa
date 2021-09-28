using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class HistoriaClinica : Diagnostico
    {
        public Mascota  Mascota { get; set; }
        public Chequeo Chequeo { get; set; }
        public Dueño  Dueño { get; set; }
    }
}