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
    public class AddAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar  _repoAuxiliar;
        public Auxiliar auxiliar {get; set;}
        
        public AddAuxiliaresModel (IRepositorioAuxiliar _repoAuxiliar)
        {
            this._repoAuxiliar = _repoAuxiliar;
        }

        public void OnGet()
        {
            auxiliar = new Auxiliar();
        }
        public IActionResult OnPost(Auxiliar auxiliar){
            if(ModelState.IsValid){
                try{
                    _repoAuxiliar.AddAuxiliar(auxiliar);
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