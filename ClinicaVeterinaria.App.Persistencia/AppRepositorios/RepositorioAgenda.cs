using System;
using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioAgenda : IRepositorioAgenda
    {
         private readonly AppContext _appContext;
        public RepositorioAgenda(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Agenda addAgendas(Agenda agenda)
        {
           Agenda agendaCruzada = _appContext.Agendas.FirstOrDefault(c=> c.Dia == agenda.Dia && agenda.Hora >= c.Hora && agenda.Hora < c.Hora.AddMinutes(30) && c.Veterinario.Id == agenda.Veterinario.Id );

            if(agendaCruzada == null){
                _appContext.Agendas.Add(agenda);
                _appContext.SaveChanges();
                return agenda;
            }
            else{
                return null;
            }
        }

        public IEnumerable<Agenda> getAgendasPerDay(DateTime dia)
        {
            return _appContext.Agendas.Where(c => c.Dia == dia).Include("Mascota").Include("Veterinario");
        }

        public IEnumerable<Agenda> getAllAgendas()
        {
            return _appContext.Agendas.Include("Mascota").Include("Veterianrio");
        }

        public int ReportAgendas(DateTime dia)
        {
            int report = _appContext.Agendas.Where(c => c.Dia == dia).Count();
            return report;
        }
    }
}
