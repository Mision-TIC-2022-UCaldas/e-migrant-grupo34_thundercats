using System.Collections.Generic;
using System.Linq;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {

        private readonly AppContext _appDbContext;

        public RepositorioEntidad(AppContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Entidad Add(Entidad entidad)
        {
            var addedEntity = _appDbContext.Entidades.Add(entidad);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public IEnumerable<Entidad> GetAll()
        {
            return _appDbContext.Entidades;
        }

        public Entidad Get(int pk)
        {
            return _appDbContext.Entidades.FirstOrDefault(p => p.Id == pk);
        }

        public bool Delete(int pk)
        {
            var entityFound = _appDbContext.Entidades.FirstOrDefault(p => p.Id == pk);
            if (entityFound == null)
                return false;
            _appDbContext.Entidades.Remove(entityFound);
            _appDbContext.SaveChanges();
            return true;
        }

        public Entidad Update(Entidad entidad)
        {
            var entityFound = _appDbContext.Entidades.FirstOrDefault(p => p.Id == entidad.Id);
            if (entityFound == null)
                return null;

            entityFound.Ciudad = entidad.Ciudad;

            _appDbContext.SaveChanges();
            return entityFound;
        }
    }
}
