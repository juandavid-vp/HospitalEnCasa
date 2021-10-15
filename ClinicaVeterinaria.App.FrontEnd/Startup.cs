using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ClinicaVeterinaria.App.Persistencia;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.FrontEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {       
            services.AddRazorPages(
                options => 
                {
                    options.Conventions.AuthorizeFolder("/Anotaciones");
                    options.Conventions.AuthorizeFolder("/Agendas");
                    options.Conventions.AuthorizeFolder("/Auxiliares");
                    options.Conventions.AuthorizeFolder("/Owners");
                    options.Conventions.AuthorizeFolder("/HistoriasClinicas");
                    options.Conventions.AuthorizeFolder("/Veterinarios");
                    options.Conventions.AuthorizeFolder("/Mascotas");
                    //options.Conventions.AuthorizePage("/Index");
                    options.Conventions.AllowAnonymousToPage("/Privacy");
                } 
                );

            //AppContext _appcontext = new AppContext();
            services.AddRazorPages();
            services.AddSingleton<IRepositorioVeterinario>(new RepositorioVeterinario(new Persistencia.AppContext()));  
            services.AddSingleton<IRepositorioMascota>(new RepositorioMascota(new Persistencia.AppContext())); 
            services.AddSingleton<IRepositorioAuxiliar>(new RepositorioAuxiliar(new Persistencia.AppContext()));
            services.AddSingleton<IRepositorioOwner>(new RepositorioOwner(new Persistencia.AppContext()));
            services.AddSingleton<IRepositorioAgenda>(new RepositorioAgenda(new Persistencia.AppContext()));
            //services.AddSingleton<IRepositorioDiagnostico>(new RepositorioDiagnostico(new Persistencia.AppContext()));
            services.AddSingleton<IRepositorioHistoriaClinica>(new RepositorioHistoriaClinica(new Persistencia.AppContext()));
            services.AddSingleton<IRepositorioAnotacion>(new RepositorioAnotacion(new Persistencia.AppContext()));
            services.AddSingleton<IRepositorioAgenda>(new RepositorioAgenda(new Persistencia.AppContext()));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
