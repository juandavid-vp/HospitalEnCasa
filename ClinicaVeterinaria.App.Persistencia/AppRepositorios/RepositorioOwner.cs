using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioOwner : IRepositorioOwner
    {
        ///<Summary>
        /// Referencia al contexto del Dueño
        ///</Summary>

        private readonly AppContext _appContext;
        ///<Summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para usar el contexto
        ///</Summary>
        ///<param name="appContext"><param/>//

        public RepositorioOwner(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Owner AddOwner(Owner owner)
        {
            var ownerAdicionado= _appContext.Owners.Add(owner);
            _appContext.SaveChanges();
            return ownerAdicionado.Entity;
        }
        public void DeleteOwner(int idOwner)
        {
            var ownerEncontrado=_appContext.Owners.FirstOrDefault(o => o.Id==idOwner);
            if(ownerEncontrado==null)
            return;
            _appContext.Owners.Remove(ownerEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Owner> GetAllOwners()
        {
            return _appContext.Owners;
        }
        public Owner GetOwner(int idOwner)
        {
            return _appContext.Owners.FirstOrDefault(o => o.Id==idOwner);
        }
        public Owner UpdateOwner(Owner owner)
        {
        var ownerEncontrado=_appContext.Owners.FirstOrDefault(o => o.Id == owner.Id);
            if(ownerEncontrado!=null)
            {
                ownerEncontrado.Nombre=owner.Nombre;
                ownerEncontrado.Ciudad=owner.Ciudad;
                ownerEncontrado.CorreoElectronico=owner.CorreoElectronico;
                ownerEncontrado.Direccion=owner.Direccion;
                ownerEncontrado.NumeroTelefono=owner.NumeroTelefono;
                ownerEncontrado.FechaNacimiento=owner.FechaNacimiento;
               

                _appContext.SaveChanges();
            }
            return ownerEncontrado;
        }
    }
}