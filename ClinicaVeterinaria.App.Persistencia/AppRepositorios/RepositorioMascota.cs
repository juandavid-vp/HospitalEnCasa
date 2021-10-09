using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;
using System.Linq;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;
        public RepositorioMascota(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public void AddMascota(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }

        public Mascota addMascotas(Mascota mascota)
        {
            Mascota newMascota = _appContext.Add(mascota).Entity;
            _appContext.SaveChanges();
            return newMascota;
        }

        public Mascota editMascotas(Mascota mascota)
        {
             Mascota mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == mascota.MascotaId);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.MascotaId = mascota.MascotaId;
                mascotaEncontrado.Nacimiento = mascota.Nacimiento;
                mascotaEncontrado.Peso = mascota.Peso;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Descripción = mascota.Descripción;
                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }

        public IEnumerable<Mascota> getAllMascotas()
        {
            return _appContext.Mascotas;
        }

        public Mascota getMascotas(int MascotaId)
        {
            Mascota mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == MascotaId);
            return mascotaEncontrado;
        }

        public void removeMascotas(int MascotaId)
        {
            Mascota mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == MascotaId);
            if(mascotaEncontrado != null)
            {
                _appContext.Mascotas.Remove(mascotaEncontrado);
                _appContext.SaveChanges();
            }

        }

    }
}