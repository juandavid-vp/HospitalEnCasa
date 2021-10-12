using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaVeterinaria.App.FrontEnd.Pages
{
    public class editVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public Veterinario veterinario {get; set; }
        
        public editVeterinarioModel(RepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }

        public void OnGet(int Cedula)
        {
            veterinario = repositorioVeterinario.getVeterinarios(Cedula);
        }
        public IActionResult OnPost(Veterinario veterinario)
        {
            try
            {
                repositorioVeterinario.editVeterinarios(veterinario);
                return RedirectToPage("./ListVeterinarios");
            }
            catch
            {
                return RedirectToPage("./Error");
            }
        }
    }
}
