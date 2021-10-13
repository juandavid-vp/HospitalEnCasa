using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.AspNetCore;

namespace ClinicaVeterinaria.App.FrontEnd.Pages
{
    public class addMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioVeterinario repositorioVeterinario;
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        private readonly IRepositorioOwner repositorioOwner;
        public Mascota mascota{get; set;}
        public IEnumerable<SelectListItem> Veterinarios {get;set;}
        public IEnumerable<SelectListItem> Auxiliares { get; set;}
        public IEnumerable<SelectListItem> Owners { get; set;}
        public int CedulaVeterinario{ get; set;}
        public int CedulaAuxiliar{ get; set;}
        public int CedulaOwners { get; set; }
        

        public addMascotaModel(IRepositorioMascota repositorioMascota, IRepositorioVeterinario repositorioVeterinario,
         IRepositorioAuxiliar repositorioAuxiliar,IRepositorioOwner repositorioOwner)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
            this.repositorioOwner = repositorioOwner;
            this.repositorioVeterinario = repositorioVeterinario;
            this.repositorioMascota = repositorioMascota;
            mascota = new Mascota();
            Veterinarios = repositorioVeterinario.getAllVeterinarios().Select(
                a => new SelectListItem
                { 
                    Value = Convert.ToString(a.Cedula),
                    Text = a.Nombre 
                }
                ).ToList();
            Auxiliares = repositorioAuxiliar.getAllAuxiliares().Select(
                a => new SelectListItem
                {
                    Value = Convert.ToString(a.Cedula),
                    Text = a.Nombre
                }
                   
                ).ToList();
            Owners = repositorioOwner.GetAllOwners().Select(
                a => new SelectListItem
                {
                    Value = Convert.ToString(a.Cedula),
                    Text = a.Nombre
                }
                ).ToList();

        }
        public void OnGet()
        {
            mascota = new Mascota();
        }
        public async Task <IActionResult> OnPostAsync (Mascota mascota, int CedulaVeterinario, int CedulaAuxiliar, int CedulaOwner)
        {         
            const string returnUrl = "./Pacientes/ListPaciente";
            if (ModelState.IsValid)
            {
                if(result.Succeeded)
                {
                    Veterinario veterinario = repositorioVeterinario.getVeterinarios(CedulaVeterinario);
                    Auxiliar auxiliar = repositorioAuxiliar.getAllAuxiliares(CedulaAuxiliar);
                    Owner owner = repositorioOwner.getOwners(CedulaAuxiliar);

                    Mascota newMascota =  new Mascota()
                    {
                        MascotaId= mascota.MascotaId,
                        NombreM = mascota.NombreM,
                        Nacimiento = mascota.Nacimiento,
                        Descripción = mascota.Descripción,
                        Peso = mascota.Peso,
                        Especie = mascota.Especie,
                        Color = mascota.Color,
                        owner = mascota.owner,
                        veterinario = mascota.veterinario,
                        auxiliar = mascota.auxiliar,
                        Password = mascota.Password,
                    };
                    repositorioMascota.addMascotas(newMascota);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
             return Page();
        }
    }
}