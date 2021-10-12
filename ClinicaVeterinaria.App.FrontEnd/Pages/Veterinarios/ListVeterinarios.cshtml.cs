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
    public class ListVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario RepositorioVeterinario;
        public IEnumerable<Veterinario> Veterinarios; 
        public ListVeterinariosModel(IRepositorioVeterinario RepositorioVeterinario)
        {
            this.RepositorioVeterinario = RepositorioVeterinario;
        }
        public void OnGet()
        {
           Veterinarios = RepositorioVeterinario.getAllVeterinarios();
        }
    }
}
