using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioOwner
    {
        IEnumerable<Owner> GetAllOwners();
        Owner AddOwner (Owner owner);
        Owner UpdateOwner (Owner owner);
        Owner GetOwner (int idOwner);
        void DeleteOwner (int idOwner);
    }
}