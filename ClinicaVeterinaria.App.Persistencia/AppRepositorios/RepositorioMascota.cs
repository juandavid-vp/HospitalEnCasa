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
        }

        public Mascota editMascotas(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Mascota> getAllMascotas()
        {
            throw new System.NotImplementedException();
        }

        public Mascota getMascotas(int IdMascota)
        {
            throw new System.NotImplementedException();
        }

        public void removeMascotas(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }
    }
}