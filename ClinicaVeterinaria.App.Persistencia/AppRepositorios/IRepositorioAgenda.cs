using System;
using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioAgenda
    {
        IEnumerable<Agenda> getAllAgendas();
        Agenda addAgendas(Agenda agenda);
        IEnumerable<Agenda> getAgendasPerDay(DateTime dia);
        int ReportAgendas(DateTime dia);
    }
}