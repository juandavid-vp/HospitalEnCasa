using ClinicaVeterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{get; set;}
        public DbSet<Dueño> Dueños{get; set;}
        public DbSet<Veterinario> Veterinarios{get; set;}
        public DbSet<Auxiliar> Auxiliares{get; set;}
        public DbSet<Mascota> Mascotas{get; set;}
        public DbSet<HistoriaClinica>historiaClinicas{get; set;}
        public DbSet<>        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data source = (localdb)\\MSSQLLocalDb;Initial catalog =ClinicaVeterinariatdata");
            }    
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*builder.Entity<Persona>()
                .HasIndex(u => u.Cedula)
                .IsUnique();*/
            builder.Entity<Mascota>()
                .HasIndex(u => u.IdMascota)
                .IsUnique();
        }
    }
}