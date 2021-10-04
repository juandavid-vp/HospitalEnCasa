using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;
using System.Linq;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioMascota 
    {
        IEnumerable<Mascota> getAllMascotas();
        Mascota AddMascota (Mascota mascota);
        Mascota UpdateMascota (Mascota mascota);
        Mascota GetMascota (int IdMascota);
        void DeleteMascota (int IdMascota);
    }
}