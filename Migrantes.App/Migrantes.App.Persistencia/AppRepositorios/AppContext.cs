using Microsoft.EntityFrameworkCore;

using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia{

    public class AppDbContext:DbContext{    // Ante AppContex

        public DbSet <Entidad> Entidades {get;set;}
        public DbSet <Servicio> Servicios {get;set;}
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Migrante> Migrantes {get;set;}
        public DbSet <Necesidades> NecesidadesDb {get;set;}
        public DbSet <Amigosyfamiliares> Amigosyfamiliares1 {get;set;}
        public DbSet <CalificacionServicios>  CalificacionesServicios {get;set;}
        public DbSet <CalificacionApp> CalificacionApp {get;set;}
        public DbSet <Emergencias> Emergencias {get;set;}


        public DbSet <Novedad> Novedades {get;set;}
        public DbSet <Usuario> Usuarios {get;set;}

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder ){
            if (!optionsBuilder.IsConfigured){
                // optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog=Thundercats"); // La usan ustedes
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog = Thundercats;Integrated Security = True"); // La uso yo
            }
        }

    }
}
