using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioChequeo
    {
         IEnumerable<Chequeo> getAllChequeos();
        Chequeo getHistoriaClinicas(int ChequeoId);
        Chequeo editChequeos(Chequeo chequeo);
        Chequeo addChequeos(Chequeo chequeo);
        void removeHistoriaClinicas(Chequeo chequeo);
    }
}