using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;
        public RepositorioVeterinario(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Veterinario addVeterinarios(Veterinario veterinario)
        {
            Veterinario newVeterinario = _appContext.Add(veterinario).Entity;
            _appContext.SaveChanges();
            return newVeterinario;
        }

        public Veterinario editVeterinarios(Veterinario veterinario)
        {
            Veterinario veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinario.Id);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Id = veterinario.Id;
                veterinarioEncontrado.Nombre = veterinario.Nombre;
               veterinarioEncontrado.FechaNacimiento = veterinario.FechaNacimiento;
                veterinarioEncontrado.Cedula = veterinario.Cedula;
                veterinarioEncontrado.NumeroTelefono= veterinario.NumeroTelefono;
                veterinarioEncontrado.CorreoElectronico = veterinario.CorreoElectronico;
                veterinarioEncontrado.HorarioLaboral = veterinario.HorarioLaboral;
                veterinarioEncontrado.LicenciaProfesional = veterinario.LicenciaProfesional;
                veterinarioEncontrado.Especializacion = veterinario.Especializacion;
                veterinarioEncontrado.EstadoVeterinario = veterinario.EstadoVeterinario;
                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }

        public IEnumerable<Veterinario> getAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario getVeterinarios(int Cedula)
        {
            Veterinario veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Cedula == Cedula);
            return veterinarioEncontrado;
        }

        public void removeVeterinarios(int Cedula)
        {
            Veterinario veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Cedula == Cedula);
            if(veterinarioEncontrado != null)
            {
                _appContext.Veterinarios.Remove(veterinarioEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
}