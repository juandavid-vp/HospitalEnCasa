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
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System.Timers;

namespace ClinicaVeterinaria.App.FrontEnd.Pages
{
    public class addVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public Veterinario veterinario { get; set; }
    
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<addVeterinarioModel> _logger;
        private readonly ICorreoElectronicoSender _correoElectronicoSender;

        private readonly RoleManager<IdentityRole> roleManager;

        public addVeterinarioModel(IRepositorioVeterinario repositorioVeterinario,
        UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<addVeterinarioModel> logger,
            ICorreoElectronicoSender correoElectronicoSender,
            RoleManager<IdentityRole> roleManager)
        {
            this.repositorioVeterinario = repositorioVeterinario;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _correoElectronicoSender = correoElectronicoSender;
            this.roleManager = roleManager;
            veterinario = new Veterinario();
        }
        public void OnGet()
        {
            
        }

    
        public async Task<IActionResult> OnPostAsync(Veterinario veterinario)
        {
            const string returnUrl = "Veterinarios/ListVeterinarios";
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = veterinario.UserName, CorreoElectronico = veterinario.CorreoElectronico, CorreoElectronicoConfirmed = true };
                var result = await _userManager.CreateAsync(user, veterinario.Password).ConfigureAwait(false);
                var existeRol = await roleManager.RoleExistsAsync("Veterinario").ConfigureAwait(false);

                if(!existeRol){
                    var role = new IdentityRole {
                        Name = "Veterinario"
                    };
                    await roleManager.CreateAsync(role).ConfigureAwait(false);
                }

                if (result.Succeeded)
                {
                    repositorioVeterinario.addVeterinarios(veterinario);

                    _logger.LogInformation("Usuario creado con contraseña");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user).ConfigureAwait(false);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code, returnUrl },
                        protocol: Request.Scheme);

                    await _correoElectronicoSender.SendEmailAsync(veterinario.CorreoElectronico, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.").ConfigureAwait(false);

                    _ = await _userManager.AddToRoleAsync(user, "Veterinario").ConfigureAwait(false);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { veterinario.CorreoElectronico, returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false).ConfigureAwait(false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
