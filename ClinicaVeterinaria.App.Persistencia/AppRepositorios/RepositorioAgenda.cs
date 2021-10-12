using System;
using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioAgenda : IRepositorioAgenda
    {
        public Agenda addAgendas(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Agenda> getAgendasPerDay(DateTime dia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Agenda> getAllAgendas()
        {
            throw new NotImplementedException();
        }

        public int ReportAgendas(DateTime dia)
        {
            throw new NotImplementedException();
        }
    }
}
