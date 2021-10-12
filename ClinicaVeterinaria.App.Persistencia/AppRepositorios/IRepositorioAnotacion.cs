using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{

    public interface IRepositorioAnotacion
    {
        IEnumerable<Anotacion> getAllAnotaciones();
        Anotacion getAllAnotaciones(int AnotacionId);
        Anotacion addAnotaciones(Anotacion anotacion);
        Anotacion editAnotaciones(Anotacion anotacion);
        void removeAnotaciones(int AnotacionId);
    }
}