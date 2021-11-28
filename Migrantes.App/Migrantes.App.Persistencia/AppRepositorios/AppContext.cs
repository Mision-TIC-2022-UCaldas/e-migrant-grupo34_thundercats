using Microsoft.EntityFrameworkCore;

using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia{

    public class AppDbContext:DbContext{    // Ante AppContex

        public DbSet <Entidad> Entidades {get;set;}
        public DbSet <Servicio> Servicios {get;set;}
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Migrante> Migrantes {get;set;}

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder ){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog = Thundercats;Integrated Security = True");
            }
        }

    }
}
