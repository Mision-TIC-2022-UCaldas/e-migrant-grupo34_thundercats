using Migrantes.App.Dominio;
using System.Linq;
using Migrantes.App.Persistencia;


namespace Migrantes.App.Persistencia{

    public class RepositorioCalificacionApp: IRepositorioCalificacionApp{
        private readonly AppDbContext _appContext = new AppDbContext();

        public CalificacionApp AddCalificacionApp(CalificacionApp calificacionApp)
        {
            var CalificacionAdicionada= _appContext.CalificacionApp.Add(calificacionApp);
            _appContext.SaveChanges();
           return CalificacionAdicionada.Entity;
        }
    }
}