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
    public class AddPetModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        public Mascota mascota {get; set;}


        public AddPetModel(IRepositorioMascota _repoMascota)
        {
            this._repoMascota = _repoMascota;
        }


        public void OnGet()
        {
            mascota = new Mascota();
        }

        public IActionResult OnPost(Mascota mascota){
            if(ModelState.IsValid){    
                try{
                    _repoMascota.AddMascota(mascota);
                    
                    return RedirectToPage("/Home/PetSuccess");
                }
                catch{
                    return RedirectToPage("../Error");
                }
            }    
            else{
                return Page();
            }
        }
    }
}