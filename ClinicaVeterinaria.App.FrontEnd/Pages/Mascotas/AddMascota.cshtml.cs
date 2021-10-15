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
        
        public Mascota mascota{get; set;}
        public addMascotaModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        public void OnGet()
        {
            mascota = new Mascota();
        }
        public IActionResult OnPost(Mascota mascota)
        {            
            try
            {
                 repositorioMascota.addMascotas(mascota);
                return RedirectToPage("./ListMascotas");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    
    }
}
