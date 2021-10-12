using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{

    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        private readonly AppContext _appContext;
        public RepositorioAuxiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Auxiliar addAuxiliares(Auxiliar auxiliar)
        {
            Auxiliar newAuxiliar = _appContext.Add(auxiliar).Entity;
            _appContext.SaveChanges();
            return newAuxiliar;
        }

        public Auxiliar editAuxiliares(Auxiliar auxiliar)
        {
            Auxiliar auxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(a => a.Id == auxiliar.Id);
            if (auxiliarEncontrado != null)
            {
                auxiliarEncontrado.Id = auxiliar.Id;
                auxiliarEncontrado.Nombre = auxiliar.Nombre;
                auxiliarEncontrado.FechaNacimiento = auxiliar.FechaNacimiento;
                auxiliarEncontrado.Cedula = auxiliar.Cedula;
                auxiliarEncontrado.NumeroTelefono= auxiliar.NumeroTelefono;
                auxiliarEncontrado.CorreoElectronico = auxiliar.CorreoElectronico;
                auxiliarEncontrado.HorarioLaboral = auxiliar.HorarioLaboral;
                auxiliarEncontrado.LicenciaProfesional = auxiliar.LicenciaProfesional;
                auxiliarEncontrado.Especializacion = auxiliar.Especializacion;
                auxiliarEncontrado.EstadoVeterinario = auxiliar.EstadoVeterinario;
                _appContext.SaveChanges();
            }
            return auxiliarEncontrado;
        }

        public IEnumerable<Auxiliar> getAllAuxiliares()
        {
            return _appContext.Auxiliares;
        }

        public Auxiliar getAllAuxiliares(int Cedula)
        {
            Auxiliar auxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(a => a.Cedula == Cedula);
            return auxiliarEncontrado;
        }

        public void removeAxiliares(int Cedula)
        {
            Auxiliar auxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(a => a.Cedula == Cedula);
            if(auxiliarEncontrado != null)
            {
                _appContext.Auxiliares.Remove(auxiliarEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
} 