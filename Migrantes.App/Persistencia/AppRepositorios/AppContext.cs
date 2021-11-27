using Microsoft.EntityFrameworkCore;

using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia{

    public class AppContext:DbContext{

        public DbSet <Entidad> Entidad {get;set;}
        // public DbSet <Migrante> Migrantes {get;set;}

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder ){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog=Thundercats");
            }
        }

    }
}
