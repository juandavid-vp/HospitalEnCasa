using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
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

        public RepositorioAuxiliar(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Auxiliar AddAuxiliar (Auxiliar auxiliar)
        {
            var auxiliarAdicionado= _appContext.Auxiliares.Add(auxiliar);
            _appContext.SaveChanges();
            return auxiliarAdicionado.Entity;
        }
        public void DeleteAuxiliar(int idAuxiliar)
        {
            var auxiliarEncontrado=_appContext.Auxiliares.FirstOrDefault(a => a.Id==idAuxiliar);
            if(auxiliarEncontrado==null)
            return;
            _appContext.Auxiliares.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Auxiliar> GetAllAuxiliares()
        {
            return _appContext.Auxiliares;
        }
        public Auxiliar GetAuxiliar(int idAuxiliar)
        {
            return _appContext.Auxiliares.FirstOrDefault(a => a.Id==idAuxiliar);
        }
        public Auxiliar UpdateAuxiliar (Auxiliar auxiliar)
        {
        var auxiliarEncontrado=_appContext.Auxiliares.FirstOrDefault(a => a.Id == auxiliar.Id);
            if(auxiliarEncontrado!=null)
            {
                auxiliarEncontrado.Nombre=auxiliar.Nombre;
                auxiliarEncontrado.CorreoElectronico=auxiliar.CorreoElectronico;
                auxiliarEncontrado.NumeroTelefono=auxiliar.NumeroTelefono;
                auxiliarEncontrado.FechaNacimiento=auxiliar.FechaNacimiento;
                auxiliarEncontrado.HorarioLaboral=auxiliar.HorarioLaboral;
               

                _appContext.SaveChanges();
            }
            return auxiliarEncontrado;
        }
    }
}