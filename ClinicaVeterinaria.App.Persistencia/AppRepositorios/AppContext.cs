using ClinicaVeterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Owner> Owners {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}
        public DbSet<Auxiliar> Auxiliares {get; set;}
        public DbSet<Mascota> Mascotas{get; set;}
        
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        optionsBuilder
        .UseSqlServer("Data source = (localdb)\\MSSQLLocalDb;Initial catalog =ClinicaVeterinariatdata");
        }    
    }
    }
}