using System;
using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;
        private readonly Security security ;
        public RepositorioMascota(AppContext appContext)
        {
            this._appContext = appContext;
            this.security = new Security();
        }

        public Mascota addMascotas(Mascota mascota)
        {
            String Password = mascota.Password;
            Password = security.GetMD5Hash(Password);
            mascota.Password = Password;
            Mascota newMascota = _appContext.Add(mascota).Entity;
            _appContext.SaveChanges();
            return newMascota;

        }

        public Mascota editMascotas(Mascota mascota)
        {
            Mascota mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.MascotaId == mascota.MascotaId);
            string Password = mascota.Password;
            Password = security.GetMD5Hash(Password);
            mascota.Password = Password;

            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.MascotaId = mascota.MascotaId;
                mascotaEncontrado.NombreM = mascota.NombreM;
                mascotaEncontrado.Nacimiento = mascota.Nacimiento;
                mascotaEncontrado.Peso = mascota.Peso;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Descripción = mascota.Descripción;
                mascotaEncontrado.Password = mascota.Password;
                mascotaEncontrado.owner = mascota.owner;
                mascotaEncontrado.auxiliar = mascota.auxiliar;
                mascotaEncontrado.veterinario = mascota.veterinario;
                _appContext.SaveChanges();
            }
            return mascotaEncontrado;

        }

        public IEnumerable<Mascota> getAllMascotas()
        {
            return _appContext.Mascotas.Include("owner").Include("veterinario").Include("auxiliar");
        }

        public Mascota getMascotas(int MascotaId)
        {
           //Mascota mascotaEncontrado = 
           return _appContext.Mascotas.Include("owner").Include("veterinario").Include("auxiliar").FirstOrDefault(m => m.MascotaId == MascotaId);
            //return mascotaEncontrado;

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