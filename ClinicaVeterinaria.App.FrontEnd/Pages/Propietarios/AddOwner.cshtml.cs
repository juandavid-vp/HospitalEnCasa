using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;

namespace ClinicaVeterinaria.App.Frontend.Pages
{
    public class AddOwnerModel : PageModel
    {
        private readonly IRepositorioOwner  _repoOwner;
        public Owner owner {get; set;}
        
        public AddOwnerModel (IRepositorioOwner _repoOwner)
        {
            this._repoOwner = _repoOwner;
        }

        public void OnGet()
        {
            owner = new Owner();
        }
        public IActionResult OnPost(Owner owner){
            if(ModelState.IsValid){
                try{
                    _repoOwner.AddOwner(owner);
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
/* 
 private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombre = "Santiago Robledo",
                CorreoElectronico = "SantiGatos@vethouse.com",
                NumeroTelefono = "3113112131",
                EstadoVeterinario = "Activo",
                HorarioLaboral = new DateTime(),
                LicenciaProfesional = "ABC123",
                FechaNacimiento = new DateTime(1990, 02,02),
                NumeroIdentificacion = 222,
                UserName = "Santagos87",
                PassWord = "123"
            };
                _repoVeterinario.AddVeterinario(veterinario);
                Console.WriteLine("Veterinario añadido exitosamente");
        }
*/        