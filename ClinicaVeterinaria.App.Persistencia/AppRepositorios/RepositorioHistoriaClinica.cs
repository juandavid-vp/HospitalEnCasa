using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext _appContext;
        public RepositorioHistoriaClinica(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public HistoriaClinica addHistoriaClinicas(HistoriaClinica historiaClinica)
        {
            throw new System.NotImplementedException();
        }

        public HistoriaClinica editHistoriaClinicas(HistoriaClinica historiaClinica)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<HistoriaClinica> getAllHistoriaClinicas()
        {
            throw new System.NotImplementedException();
        }

        public HistoriaClinica getHistoriaClinicas(int HistoriaId)
        {
            throw new System.NotImplementedException();
        }

        public void removeHistoriaClinicas(HistoriaClinica historiaClinica)
        {
            throw new System.NotImplementedException();
        }
    }
}