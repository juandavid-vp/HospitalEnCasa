using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{

    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> getAllAuxiliares();
        Auxiliar getAllAuxiliares(int Cedula);
        Auxiliar addAuxiliares(Auxiliar auxiliar);
        Auxiliar editAuxiliares(Auxiliar auxiliar);
        void removeAxiliares(int Cedula);
    }
}