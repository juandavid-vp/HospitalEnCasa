using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;


namespace ClinicaVeterinaria.App.Dominio
{

    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> getAllMascotas();
        Mascota getMascotas(int Cedula);
        Mascota addMascotas(Mascota mascota);
        Mascota editMascotas(Mascota mascota);
        void removeMascotas(Mascota mascota);

    }
}