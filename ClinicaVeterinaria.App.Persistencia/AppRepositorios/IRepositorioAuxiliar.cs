using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> GetAllAuxiliares();
        Auxiliar AddAuxiliar (Auxiliar auxiliar);
        Auxiliar UpdateAuxiliar (Auxiliar auxiliar);
        Auxiliar GetAuxiliar (int idAuxiliar);
        void DeleteAuxiliar (int idAuxiliar);
    }
}