using System;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;

namespace ClinicaVeterinaria.App.Consola
{
    class Presentacion
    {
        private static IRepositorioOwner _repoOwner = new RepositorioOwner (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Usuario Final, aqui podras interactuar con nuestro Software!");
            AddOwner();
        }
        private static void AddOwner()
        {
            var owner = new Owner
            {
                Nombre = "Persona nueva",
                Ciudad = "La imaginacion",
                Direccion = "Av creacion VIVA R",
                CorreoElectronico = "Programando@live.com",
                FechaNacimiento = new DateTime(992, 02, 12),
                NumeroTelefono = "3222333223"
            };
            _repoOwner.AddOwner(owner);
        }
        private static void BuscarOwner(int idOwner)
        {
            var dueño = _repoOwner.GetOwner(idOwner);
            Console.WriteLine(dueño.Nombre);
        }
