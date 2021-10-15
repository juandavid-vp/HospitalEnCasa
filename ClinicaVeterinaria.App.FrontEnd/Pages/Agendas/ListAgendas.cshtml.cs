using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;


namespace ClinicaVeterinaria.App.FrontEnd.Pages
{
    public class ListAgendasModel : PageModel
    {
        private readonly IRepositorioAgenda repositorioAgenda;
        public Agenda Agenda { get; set; }
        //public Mascota Mascota { get; set; }
        //public Veterinario Veterinario { get; set; }
       // public DateTime Dia { get; set; }
        //public Agenda Dia { get; set; }

        public IEnumerable<Agenda> Agendas;
        [DataType(DataType.Date),Range(typeof(DateTime), "1/1/2021", "31/12/2025",
        ErrorMessage = "El valor {0} debe estar {1} y {2}")]
        public DateTime Dia { get; set; }

        [DataType(DataType.Date),Range(typeof(DateTime), "1/1/2021", "31/12/2025",
        ErrorMessage = "El valor {0} debe estar {1} y {2}")]
        public DateTime DiaInicial { get; set; }
        [DataType(DataType.Date),Range(typeof(DateTime), "1/1/2021", "31/12/2025",
        ErrorMessage = "El valor {0} debe estar {1} y {2}")]
        public DateTime DiaFinal { get; set; }
        public ListAgendasModel(IRepositorioAgenda repositorioAgenda)
        {
            this.repositorioAgenda = repositorioAgenda; 
            Agendas = repositorioAgenda.getAllAgendas();
        }
        public void OnGet()
        {
            Agendas = repositorioAgenda.getAllAgendas();
        }
    }
}
