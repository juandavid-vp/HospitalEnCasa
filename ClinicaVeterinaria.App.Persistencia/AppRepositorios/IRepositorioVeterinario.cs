using System;
using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinario (Veterinario veterinario );
        Veterinario UpdateVeterinario (Veterinario veterinario);
        Veterinario GetVeterinario (int idVeterinario);
        void DeleteVeterinario (int idVeterinario);
    }
}