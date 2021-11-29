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

        

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder ){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog=Thundercats");
            }
        }

    }
}
