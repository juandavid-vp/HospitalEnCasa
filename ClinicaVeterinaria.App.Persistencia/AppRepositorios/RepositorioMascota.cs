using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;
using System.Linq;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;
        ///<Summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para usar el contexto
        ///</Summary>
        ///<param name="appContext"><param/>//

        public RepositorioMascota(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Mascota AddMascota (Mascota mascota)
        {
            var mascotaAdicionada = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.Id == mascota.Id);            
            if (mascotaEncontrada != null)
            {
                mascotaEncontrada.Nacimiento = mascota.Nacimiento;
                mascotaEncontrada.Peso = mascota.Peso;
                mascotaEncontrada.Raza = mascota.Raza;
                mascotaEncontrada.Color = mascota.Color;
                mascotaEncontrada.Descripción = mascota.Descripción;
               
                _appContext.SaveChanges();
            }
            return mascotaEncontrada;
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        public Mascota GetMascota(int IdMascota)
        {           
            return _appContext.Mascotas.FirstOrDefault(m => m.Id==IdMascota);
        }

        public void DeleteMascota(int IdMascota)
        {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.Id == IdMascota);
            if(mascotaEncontrada != null)
            return; 
                _appContext.Mascotas.Remove(mascotaEncontrada);
                _appContext.SaveChanges();
        }
    }
}