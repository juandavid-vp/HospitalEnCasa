using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        ///<Summary>
        /// Referencia al contexto del Dueño
        ///</Summary>

        private readonly AppContext _appContext;
        ///<Summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para usar el contexto
        ///</Summary>
        ///<param name="appContext"><param/>//

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Veterinario AddVeterinario (Veterinario veterinario)
        {
            var veterinarioAdicionado= _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        public void DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Id==idVeterinario);
            if(veterinarioEncontrado==null)
            return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }
        public Veterinario GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Id==idVeterinario);
        }
        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinario.Id);
            if(veterinarioEncontrado!=null)
            {
                veterinarioEncontrado.Nombre=veterinario.Nombre;
                veterinarioEncontrado.CorreoElectronico=veterinario.CorreoElectronico;
                veterinarioEncontrado.NumeroTelefono=veterinario.NumeroTelefono;
                veterinarioEncontrado.FechaNacimiento=veterinario.FechaNacimiento;
                veterinarioEncontrado.HorarioLaboral=veterinario.HorarioLaboral;
                veterinarioEncontrado.EstadoVeterinario=veterinario.EstadoVeterinario;
                veterinarioEncontrado.NumeroIdentificacion=veterinario.NumeroIdentificacion;
                veterinarioEncontrado.UserName=veterinario.UserName;
                veterinarioEncontrado.PassWord=veterinario.PassWord;
                veterinarioEncontrado.LicenciaProfesional=veterinario.LicenciaProfesional;

                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }   
    }
}