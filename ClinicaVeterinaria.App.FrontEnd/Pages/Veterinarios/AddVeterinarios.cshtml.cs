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
    public class AddVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario  _repoVeterinario;
        public Veterinario veterinario {get; set;}
        
        public AddVeterinariosModel (IRepositorioVeterinario _repoVeterinario)
        {
            this._repoVeterinario = _repoVeterinario;
        }

        public void OnGet()
        {
            veterinario = new Veterinario();
        }
        public IActionResult OnPost(Veterinario veterinario){
            if(ModelState.IsValid){
                try{
                    _repoVeterinario.AddVeterinario(veterinario);
                    return RedirectToPage("../Privacy");
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