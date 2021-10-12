using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{

    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> getAllVeterinarios();
        Veterinario getVeterinarios(int Cedula);
        Veterinario addVeterinarios(Veterinario veterinario);
        Veterinario editVeterinarios(Veterinario veterinario);
        void removeVeterinarios(int Cedula);
    }
}