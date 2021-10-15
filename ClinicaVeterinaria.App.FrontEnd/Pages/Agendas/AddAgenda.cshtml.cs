using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClinicaVeterinaria.App.FrontEnd
{
    public class addAgendaModel : PageModel
    {
        private readonly IRepositorioAgenda repositorioAgenda;
        private readonly IRepositorioVeterinario repositorioVeterinario;
        private readonly IRepositorioMascota repositorioMascota;

        public Agenda agenda { get; set; }
        public Veterinario veterinario { get; set; }
        public Mascota mascota { get; set; }
        public SelectList Veterinario { get; set; }
        public SelectList Mascota { get; set; }

        public int CedulaVeterinario { get; set; }
        public int MascotaIdMascota { get; set; }

        public string mensaje {get; set; }

        public addAgendaModel(IRepositorioAgenda repositorioAgenda , IRepositorioVeterinario repositorioVeterinario ,
         IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
            this.repositorioAgenda = repositorioAgenda;
            this.repositorioVeterinario = repositorioVeterinario;

            Veterinario = new SelectList(repositorioVeterinario.getAllVeterinarios(),nameof(veterinario.Cedula),nameof(veterinario.Nombre));
            Mascota = new SelectList(repositorioMascota.getAllMascotas(),nameof(mascota.MascotaId),nameof(mascota.NombreM));
        }
        
        public void OnGet()
        {

        }

        public IActionResult OnPost(Agenda agenda, int CedulaVeterinario, int MascotaIdMascota)
        {
            if(ModelState.IsValid)
            {
                veterinario = repositorioVeterinario.getVeterinarios(CedulaVeterinario);
                mascota = repositorioMascota.getMascotas(MascotaIdMascota);

                Agenda newAgenda = new Agenda()
                {
                    Veterinario = veterinario,
                    Mascota = mascota,
                    Descripcion = agenda.Descripcion,
                    Dia = agenda.Dia,
                    Hora = agenda.Hora
                };

                Agenda AgendaResultante = repositorioAgenda.addAgendas(newAgenda);

                if(AgendaResultante== null)
                {
                    mensaje = "El médico tiene una cita a la misma hora, seleccione otra";
                    return Page();
                }
                else
                {
                    return RedirectToPage("./ListAgendas");
                }
            }
            else
            {                             
            return Page();
            }
        }
    }
    
    
       
}
