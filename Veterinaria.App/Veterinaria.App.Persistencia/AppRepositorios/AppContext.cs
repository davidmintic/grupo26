using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<EntidadPersona> Personas {get; set;}
        public DbSet<EntidadVeterinario> Veterinarios {get; set;}
        public DbSet<EntidadCuidador> Cuidadores {get; set;}
        public DbSet<EntidadMascota> Mascotas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =VeterinariaGrupo26");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<EntidadMascota>().HasOne(c => c.Cuidador).WithMany(m => m.Mascotas).IsRequired();
        }
        

    }
    
}