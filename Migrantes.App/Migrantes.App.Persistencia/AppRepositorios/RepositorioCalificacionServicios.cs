using Migrantes.App.Dominio;
using System.Linq;


namespace Migrantes.App.Persistencia{

    public class RepositorioCalificacionServicios: IRepositorioCalificacionServicios{
        private readonly AppDbContext _appContext = new AppDbContext();

        public CalificacionServicios AddCalificacionServicios(CalificacionServicios calificacionServicios)
        {
            var CalificacionAdicionada= _appContext.CalificacionesServicios.Add(calificacionServicios);
            _appContext.SaveChanges();
            return CalificacionAdicionada.Entity;
        }
    }
}