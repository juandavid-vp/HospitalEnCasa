using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
        IEnumerable<HistoriaClinica> getAllHistoriaClinicas();
        HistoriaClinica getHistoriaClinicas(int HistoriaId);
        HistoriaClinica editHistoriaClinicas(HistoriaClinica historiaClinica);
        HistoriaClinica addHistoriaClinicas(HistoriaClinica historiaClinica);
        void removeHistoriaClinicas(HistoriaClinica historiaClinica);
    }
}