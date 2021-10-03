using System;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;


namespace ClinicaVeterinaria.App.Consola
{
    class Presentacion
    {
        private static IRepositorioOwner _repoOwner = new RepositorioOwner(new Persistencia.AppContext());

        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        private static IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");           
        }
        
        
        // Dueño de mascotas 
        // Añadir un dueño.
        private static void AddOwner()
        {
            var owner = new Owner
            {
                Nombre = "Sol acosta",
                Ciudad = "Tocancipa",
                Direccion = "Avcalle 2# 23-34",
                CorreoElectronico = "emprende@ahora.es",
                FechaNacimiento = new DateTime(1901, 01, 11),
                NumeroIdentificacion = 104818273

            };
            _repoOwner.AddOwner(owner);
        }
        
        //Buscar un dueño
        private static void GetOwner(int idOwner)
        {
            var owner = _repoOwner.GetOwner(idOwner);
            Console.WriteLine(owner.Nombre + " " + owner.Ciudad);
        }
        
        //Buscar todos los dueños.
        private static void GetAllOwners()
        {
            var ownersEncontrados = _repoOwner.GetAllOwners();
            Console.WriteLine(ownersEncontrados);
        } 
        
        /*
        No esta funcionando esta funcion.
        // Actualizar un dueño.
        private static void UpdateOwner()
        {
            
           
            var ownerEncontrado = _repoOwner.GetOwner());
            {
                ownerEncontrado.Nombre = "Niu user";
                /*ownerEncontrado.Ciudad = "Manizales",
                ownerEncontrado.NumeroTelefono = "3122222222",
                ownerEncontrado.CorreoElectronico = "Niumani@usurio.es",
                ownerEncontrado.Direccion = "Calle 4 # 33B-12 SUR",
                ownerEncontrado.UserName = "NuSeR78",
                ownerEncontrado.PassWord = "123",
                ownerEncontrado.FechaNacimiento = new DateTime (),
                ownerEncontrado.NumeroIdentificacion = 213123,
                ownerEncontrado.EstadoDueño = "Activo"
            };
            _repoOwner.UpdateOwner(ownerEncontrado);
            Console.WriteLine("Propietario actualizado correctamente.");
        }    */
        
        // Eliminar un dueño
        private static void DeleteOwner(int idOwner)
        {
            var ownerEncontrado = _repoOwner.GetOwner(idOwner);
            _repoOwner.DeleteOwner(idOwner);
            Console.WriteLine("La eliminacion fue exitosa");
            return;
        }
        
        // Veterinarios
        // Añadir
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
        
        // Buscar un veterinario
        private static void GetVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine("El veterinario que usted busca es: \n");
            Console.WriteLine(veterinario.Nombre + " y su estatus es: " + veterinario.EstadoVeterinario);
        }

        // Eliminar un veterinario
        private static void DeleteVeterinario(int idVeterinario)
        {       
            var veterinarioEncontrado = _repoVeterinario.GetVeterinario(idVeterinario);
            _repoVeterinario.DeleteVeterinario(idVeterinario);
            Console.WriteLine("La eliminacion fue exitosa");
            return;
        }

        // Obtener todos los veterinarios
        private static void GetAllVeterinarios()
        {
            var veterinariosEncontrados = _repoVeterinario.GetAllVeterinarios();
            Console.WriteLine(veterinariosEncontrados);
        }
        /*
        // Actualizar un veterinario
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
            _repoOwner.UpdateOwner(auxiliarEncontrado);
            Console.WriteLine("Veterinario actualizado correctamente.");
        }
        */ 

        // Auxiliaares de veterinaria
        // Añadir un auxiliar
        private static void AddAuxiliar()
        {
            var auxiliar = new Auxiliar
            {
                Nombre = "Camilo andrade",
                CorreoElectronico = "Camilo@FirtsAux.com",
                NumeroTelefono = "3114445555",
                HorarioLaboral = new DateTime(),
                FechaNacimiento =new DateTime(),
                UserName = "Caamigatos",
                PassWord = "123AA!",
                NumeroIdentificacion = 12312
            };
                _repoAuxiliar.AddAuxiliar(auxiliar);
                Console.WriteLine("Auxiliar añadido exitosamente");
        }
 
        // Buscar un auxiliar
        private static void GetAuxiliar(int idAuxiliar)
        {
            var auxiliar = _repoAuxiliar.GetAuxiliar(idAuxiliar);
            Console.WriteLine("El auxiliar que usted busca es: \n");
            Console.WriteLine(auxiliar.Nombre + " y su estatus es: " + auxiliar.EstadoAuxiliar);
        }

        // Eliminar un auxiliar
        private static void DeleteAuxiliar(int idAuxiliar)
        {
            var auxiliarEncontrado = _repoAuxiliar.GetAuxiliar(idAuxiliar);
            _repoAuxiliar.DeleteAuxiliar(idAuxiliar);
            Console.WriteLine("La eliminacion fue exitosa");
            return;
        }
        
        // Obtener todos los Auxiliares
        private static void GetAllAuxiliares()
        {
            var auxiliaresEncontrados = _repoAuxiliar.GetAllAuxiliares();
            Console.WriteLine(auxiliaresEncontrados);
        }

        /*
        // Actualizar un auxiliar
        private static void UpdateAuxiliar()
        {
            var auxiliarEncontrado = new Auxiliar
            {
            auxiliarEncontrado.Nombre = "Carlos calero",
            auxiliarEncontrado.NumeroTelefono = "3132222213",
            auxiliarEncontrado.CorreoElectronico = "Programando@stetic.tic",
            auxiliarEncontrado.HorarioLaboral = new DateTime(),
            auxiliarEncontrado.FechaNacimiento = new DateTime (2002, 03, 10)
            };
                _repoAuxiliar.UpdateAuxiliar(auxiliarEncontrado);
                Console.WriteLine("Auxiliar actualizado correctamente.");
        }
        */        
    }    
}
