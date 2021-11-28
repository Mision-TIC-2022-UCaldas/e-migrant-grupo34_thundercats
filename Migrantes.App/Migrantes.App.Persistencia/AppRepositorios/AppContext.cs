using Microsoft.EntityFrameworkCore;

using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia{

    public class AppContext:DbContext{

        public DbSet <Persona> Personas {get;set;}
        public DbSet <Migrante> Migrantes {get;set;}
        public DbSet <AmigosYFamiliares> AmigosYFamiliares1 {get;set;}
        public DbSet <Necesidades> Necesidades1 {get;set;}

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder ){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog=Thundercats");
            }
        }

    }
}