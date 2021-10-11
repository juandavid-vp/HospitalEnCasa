using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioChequeo : IRepositorioChequeo
    {
        private readonly AppContext _appContext;
        public RepositorioChequeo(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Chequeo addChequeos(Chequeo chequeo)
        {
            throw new System.NotImplementedException();
        }

        public Chequeo editChequeos(Chequeo chequeo)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Chequeo> getAllChequeos()
        {
            throw new System.NotImplementedException();
        }

        public Chequeo getHistoriaClinicas(int ChequeoId)
        {
            throw new System.NotImplementedException();
        }

        public void removeHistoriaClinicas(Chequeo chequeo)
        {
            throw new System.NotImplementedException();
        }
    }
}