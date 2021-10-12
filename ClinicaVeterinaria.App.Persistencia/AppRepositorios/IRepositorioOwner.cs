using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioOwner
    {
        IEnumerable<Owner> GetAllOwners();
        Owner getOwners(int Cedula);
        Owner addOwners(Owner owner);

        Owner editOwners(Owner owner);
        
        void removeOwners(int Cedula);
    }
}