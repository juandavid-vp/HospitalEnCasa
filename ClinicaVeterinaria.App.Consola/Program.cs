using System;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using ClinicaVeterinaria.App.Persistencia.AppRepositorios;

namespace ClinicaVeterinaria.App.Consola
{
    class Program
    {
        private static IRepositorioOwner _repoOwner = new RepositorioOwner(new Persistencia.AppContext());

        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddOwner();
        }
        
        
        private static void AddOwner()
        {
            var owner = new Owner
            {
                Nombre = "Camila Delgado",
                Ciudad = "Bogota",
                Direccion = "Avcalle 2# 23-34",
                CorreoElectronico = "emprende@ahora.es",
                FechaNacimiento = new DateTime(1901, 01, 11),

            };
            _repoOwner.AddOwner(owner);
        }
        
        
        private static void BuscarOwner(int idOwner)
        {
            var owner = _repoOwner.GetOwner(idOwner);
            Console.WriteLine(owner.Nombre + " " + owner.Ciudad);
        }
        
        
        private static void GetAllOwners()
        {
            _repoOwner.GetAllOwners();
            Console.WriteLine(GetAllOwners);
        }
        
        
        private static void UpdateOwner()
        {
            var veterinarioEncontrado = new Owner
            {
                veterinarioEncontrado.Nombre = "Niu user",
                veterinarioEncontrado.Ciudad = "Manizales",
                veterinarioEncontrado.NumeroTelefono = "3122222222",
                veterinarioEncontrado.CorreoElectronico = "Niumani@usurio.es",
                veterinarioEncontrado.Direccion = "Calle 4 # 33B-12 SUR"
            };
            _repoOwner.UpdateOwner(veterinarioEncontrado);
            Console.WriteLine("Propietario actualizado correctamente.");
        }    

        private static void DeleteOwner(int idOwner)
        {
            var veterinarioEncontrado = _repoOwner.GetOwner(idOwner);
            _repoOwner.DeleteOwner(idOwner);
            Console.WriteLine("La eliminacion fue exitosa");
            return;
        }
        
        
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombre = "Santiago Robledo",
                CorreoElectronico = "SantiGatos@vethouse.com",
                NumeroTelefono = "3113112131",
                EstadoVeterinario = "Activo",
                HorarioLaboral = new DateTime(),
                LicenciaProfesional = "ABC123"
            };
                _repoVeterinario.AddVeterinario(veterinario);
                Console.WriteLine("Veterinario añadido exitosamente");
        }
 
 
        private static void BuscarVeterinraio(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine("El veterinario que usted busca es: \n");
            Console.WriteLine(veterinario.Nombre + " y su estatus es: " + veterinaario.EstadoVeterinario);
        }


        private static void DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _repoVeterinario.GetVeterinario(idVeterinario);
            _repoVeterinario.DeleteVeterinario(idVeterinario);
            Console.WriteLine("La eliminacion fue exitosa");
            return;
        }
        
        
        private static void UpdateVeterinario()
        {
        var veterinarioEncontrado = new Veterinario
        {
            veterinarioEncontrado.Nombre = "Estefan Medina",
            veterinarioEncontrado.Ciudad = "Cucuta",
            veterinarioEncontrado.NumeroTelefono = "313333333",
            veterinarioEncontrado.CorreoElectronico = "Program@Gret.Mintic",
            veterinarioEncontrado.Direccion = "Calle 5 #13-31"
        };
            _repoOwner.UpdateOwner(veterinarioEncontrado);
            Console.WriteLine("Veterinario actualizado correctamente.");
        }    
    }
}
