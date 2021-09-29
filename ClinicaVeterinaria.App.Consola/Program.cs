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

        private static IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());

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
            var auxiliarEncontrado = new Owner
            {
                auxiliarEncontrado.Nombre = "Niu user",
                auxiliarEncontrado.Ciudad = "Manizales",
                auxiliarEncontrado.NumeroTelefono = "3122222222",
                auxiliarEncontrado.CorreoElectronico = "Niumani@usurio.es",
                auxiliarEncontrado.Direccion = "Calle 4 # 33B-12 SUR"
            };
            _repoOwner.UpdateOwner(auxiliarEncontrado);
            Console.WriteLine("Propietario actualizado correctamente.");
        }    

        private static void DeleteOwner(int idOwner)
        {
            var auxiliarEncontrado = _repoOwner.GetOwner(idOwner);
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
            var auxiliarEncontrado = _repoVeterinario.GetVeterinario(idVeterinario);
            _repoVeterinario.DeleteVeterinario(idVeterinario);
            Console.WriteLine("La eliminacion fue exitosa");
            return;
        }

         private static void GetAllVeterinarios()
        {
            _repoVeterinario.GetAllVeterinarios();
            Console.WriteLine(GetAllVeterinarios);
        }
        
        
        private static void UpdateVeterinario()
        {
        var auxiliarEncontrado = new Veterinario
        {
            auxiliarEncontrado.Nombre = "Estefan Medina",
            auxiliarEncontrado.Ciudad = "Cucuta",
            auxiliarEncontrado.NumeroTelefono = "313333333",
            auxiliarEncontrado.CorreoElectronico = "Program@Gret.Mintic",
            auxiliarEncontrado.Direccion = "Calle 5 #13-31"
        };
            _repoOwner.UpdateOwner(auxiliarEncontrado);
            Console.WriteLine("Veterinario actualizado correctamente.");
        }


        private static void AddAuxiliar()
        {
            var auxiliar = new Auxiliar
            {
                Nombre = "Camilo andrade",
                CorreoElectronico = "Camilo@FirtsAux.com",
                NumeroTelefono = "3114445555",
                HorarioLaboral = new DateTime(),
            };
                _repoAuxiliar.AddAuxiliar(auxiliar);
                Console.WriteLine("Auxiliar añadido exitosamente");
        }
 
 
        private static void BuscarAuxiliar(int idAuxiliar)
        {
            var auxiliar= _repoAuxiliar.GetAuxiliar(idAuxiliar);
            Console.WriteLine("El auxiliar que usted busca es: \n");
            Console.WriteLine(auxiliar.Nombre + " y su estatus es: " + auxiliar.EstadoVeterinario);
        }


        private static void DeleteAuxiliar(int idAuxiliar)
        {
            var auxiliarEncontrado = _repoAuxiliar.GetAuxiliar(idAuxiliar);
            _repoAuxiliar.DeleteAuxiliar(idAuxiliar);
            Console.WriteLine("La eliminacion fue exitosa");
            return;
        }
        

         private static void GetAllAuxiliares()
        {
            _repoOwner.GetAllAuxiliares();
            Console.WriteLine(GetAllAuxiliares);
        }

        
        private static void UpdateAuxiliar()
        {
        var auxiliarEncontrado = new Auxiliar
        {
            auxiliarEncontrado.Nombre = "Estefan Medina",
            auxiliarEncontrado.NumeroTelefono = "313333333",
            auxiliarEncontrado.CorreoElectronico = "Program@Gret.Mintic",
            auxiliarEncontrado.HorarioLaboral = new DateTime(),
            auxiliarEncontrado.FechaNacimiento = new DateTime (2002, 03, 10)
        };
            _repoAuxiliar.UpdateAuxiliar(auxiliarEncontrado);
            Console.WriteLine("Veterinario actualizado correctamente.");
        }    
    }    
    }
}
