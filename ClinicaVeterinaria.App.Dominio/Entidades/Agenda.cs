using System;

namespace CliniVeteriVethouse.App.Dominio
{
    public class Agenda : HorarioAtencion
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public Veterinario Veterinario { get; set; }
        public Auxiliar Auxiliar { get; set; }



    }