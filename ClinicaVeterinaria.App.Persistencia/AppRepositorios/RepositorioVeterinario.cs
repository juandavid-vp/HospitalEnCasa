using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;
using System.Linq;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class RepositorioVetrinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext;
        public RepositorioVetrinario(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            Veterinario newVeterinario = _appContext.Add(veterinario).Entity;
            _appContext.SaveChanges();
            return newVeterinario;
        }

        public void DeleteVeterinario(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Veterinario editVeterinarios(Veterinario veterinario)
        {
             Veterinario veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(m => m.Id == veterinario.Id);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Id = veterinario.Id;
                veterinarioEncontrado.Nombre = veterinario.Nombre;
                veterinarioEncontrado.FechaNacimiento = veterinario.FechaNacimiento;
                veterinarioEncontrado.Cedula = veterinario.Cedula;
                veterinarioEncontrado.NumeroTelefono = veterinario.NumeroTelefono;
                veterinarioEncontrado.CorreoElectronico = veterinario.CorreoElectronico;
                veterinarioEncontrado.HorarioLaboral = veterinario.HorarioLaboral;
                veterinarioEncontrado.LicenciaProfesional = veterinario.LicenciaProfesional;
                veterinarioEncontrado.Especializacion = veterinario.Especializacion;
                veterinarioEncontrado.EstadoVeterinario = veterinario.EstadoVeterinario;
                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }

        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario GetVeterinario(int id)
        {
            throw new System.NotImplementedException();
        }

        public Veterinario getVeterinarios(int Id)
        {
            Veterinario veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == Id);
            return veterinarioEncontrado;
        }

        public void removeVeterinarios(int Id)
        {
            Veterinario veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v=> v.Id == Id);
            if(veterinarioEncontrado != null)
            {
                _appContext.Veterinarios.Remove(veterinarioEncontrado);
                _appContext.SaveChanges();
            }

        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            throw new System.NotImplementedException();
        }
    }
}