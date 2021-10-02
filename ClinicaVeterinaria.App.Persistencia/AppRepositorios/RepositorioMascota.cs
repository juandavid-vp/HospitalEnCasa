using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;


namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;
        public RepositorioMascota(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Mascota addMascotas(Mascota mascota)
        {
            Mascota newMascota = _appContext.Add(mascota).Entity;
            _appContext.SaveChanges();
            return newMascota;
        }

        public Mascota editMascotas(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Mascota> getAllMascotas()
        {
            return _appContext.Mascotas;
        }

        public Mascota getMascotas(int IdMascota)
        {
            Mascota mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.IdMascota == IdMascota);
            return mascotaEncontrado;
        }

        public void removeMascotas(int IdMascota)
        {
            Mascota mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.IdMascota == IdMascota);
            if(mascotaEncontrado != null)
            {
                _appContext.Mascotas.Remove(mascotaEncontrado);
                _appContext.SaveChanges();
            }

        }
    }
}