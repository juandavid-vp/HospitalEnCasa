using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVeterinaria.App.Dominio;


namespace ClinicaVeterinaria.App.Frontend.Pages
{
    public class SeePetModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        public IEnumerable<Mascota> mascotas;
        public SeePetModel(IRepositorioMascota _repoMascota)
        {
            this._repoMascota = _repoMascota;
        }
        public void OnGet()
        {
            mascotas = _repoMascota.GetAllMascotas();
        }
    }
}
