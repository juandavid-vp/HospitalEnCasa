using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioAnotacion : IRepositorioAnotacion
    {
        private readonly AppContext _appContext;
        public RepositorioAnotacion(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Anotacion addAnotaciones(Anotacion anotacion)
        {
            Anotacion newAnotacion = _appContext.Add(anotacion).Entity;
            _appContext.SaveChanges();
            return newAnotacion;
        }

        public Anotacion editAnotaciones(Anotacion anotacion)
        {
            Anotacion anotacionEncontrado = _appContext.Anotaciones.FirstOrDefault(an => an.AnotacionId == anotacion.AnotacionId);
            if (anotacionEncontrado != null)
            {
                anotacionEncontrado.AnotacionId = anotacion.AnotacionId;
                anotacionEncontrado.Duracion = anotacion.Duracion;
                anotacionEncontrado.FechaHora = anotacion.FechaHora;
                anotacionEncontrado.owner = anotacion.owner;
                anotacionEncontrado.mascota = anotacion.mascota;
                anotacionEncontrado.veterinario = anotacion.veterinario;
                anotacionEncontrado.auxiliar = anotacion.auxiliar;
                _appContext.SaveChanges();
            }
            return anotacionEncontrado;
        }

        public IEnumerable<Anotacion> getAllAnotaciones()
        {
            return _appContext.Anotaciones;
        }

        public Anotacion getAllAnotaciones(int AnotacionId)
        {
            Anotacion anotacionEncontrado = _appContext.Anotaciones.FirstOrDefault(an => an.AnotacionId == AnotacionId);
            return anotacionEncontrado;
        }

        public void removeAnotaciones(int AnotacionId)
        {
            Anotacion anotacionEncontrado = _appContext.Anotaciones.FirstOrDefault(an => an.AnotacionId == AnotacionId);
            if(anotacionEncontrado != null)
            {
                _appContext.Anotaciones.Remove(anotacionEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
}