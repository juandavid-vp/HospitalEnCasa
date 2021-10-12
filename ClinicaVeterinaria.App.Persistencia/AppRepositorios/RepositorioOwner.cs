using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioOwner : IRepositorioOwner
    {
        private readonly AppContext _appContext;
        public RepositorioOwner(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Owner addOwners(Owner owner)
        {
            Owner newOwner = _appContext.Add(owner).Entity;
            _appContext.SaveChanges();
            return newOwner;
        }

        public Owner editOwners(Owner owner)
        {
            var ownerEncontrado=_appContext.Owners.FirstOrDefault(o => o.Id == owner.Id);
            if(ownerEncontrado!=null)
            {
                ownerEncontrado.Nombre=owner.Nombre;
                ownerEncontrado.Cedula=owner.Cedula;
                ownerEncontrado.Ciudad=owner.Ciudad;
                ownerEncontrado.CorreoElectronico=owner.CorreoElectronico;
                ownerEncontrado.Direccion=owner.Direccion;
                ownerEncontrado.NumeroTelefono=owner.NumeroTelefono;
                ownerEncontrado.FechaNacimiento=owner.FechaNacimiento;
                ownerEncontrado.mascota = owner.mascota;
                _appContext.SaveChanges();
            }
            return ownerEncontrado;
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return _appContext.Owners;
        }

        public Owner getOwners(int Cedula)
        {
            Owner ownerEncontrado = _appContext.Owners.FirstOrDefault(o => o.Cedula == Cedula);
            return ownerEncontrado;

        }

        public void removeOwners(int Cedula)
        {
            Owner ownerEncontrado = _appContext.Owners.FirstOrDefault(o => o.Cedula == Cedula);
            if(ownerEncontrado != null)
            {
                _appContext.Owners.Remove(ownerEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
}