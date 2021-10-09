using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVeterinaria.App.Persistencia;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.FrontEnd.Pages
{
    public class ListMascotasModel : PageModel
    {
        private readonly IRepositorioMascota RepositorioMascota;
        public IEnumerable<Mascota> mascotas; 
        public ListMascotasModel(IRepositorioMascota RepositorioMascota)
        {
            this.RepositorioMascota = RepositorioMascota;
        }
        public void OnGet()
        {
            mascotas = RepositorioMascota.getAllMascotas();
        }
    }
}
