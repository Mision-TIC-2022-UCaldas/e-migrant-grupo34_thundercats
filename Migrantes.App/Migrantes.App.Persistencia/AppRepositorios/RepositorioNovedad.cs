using System.Collections.Generic;
using System.Linq;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {

        private readonly AppDbContext _appContext = new AppDbContext();

        // public RepositorioEntidad(AppContext appDbContext)
        // {
        //     _appDbContext = appDbContext;
        // }

        public Novedad Add(Novedad entity)
        {
            var addedEntity = _appContext.Novedades.Add(entity);
            _appContext.SaveChanges();
            return addedEntity.Entity;
        }

        public IEnumerable<Novedad> GetAll()
        {
            return _appContext.Novedades;
        }


        public Novedad Get(int pk)
        {
            return _appContext.Novedades.FirstOrDefault(p => p.Id == pk);
        }

        public bool Delete(int pk)
        {
            var entityFound = _appContext.Novedades.FirstOrDefault(p => p.Id == pk);
            if (entityFound == null)
                return false;
            _appContext.Novedades.Remove(entityFound);
            _appContext.SaveChanges();
            return true;
        }

        public Novedad Update(Novedad entity)
        {
            var entityFound = _appContext.Novedades.FirstOrDefault(p => p.Id == entity.Id);
            if (entityFound == null)
                return null;

            entityFound.DiasActiva = entity.DiasActiva ;
            entityFound.FechaNovedad = entity.FechaNovedad ;
            entityFound.TextoExplicativo = entity.TextoExplicativo ;
            entityFound.EstaActiva = entity.EstaActiva ;

            _appContext.SaveChanges();
            return entityFound;
        }
    }
}
