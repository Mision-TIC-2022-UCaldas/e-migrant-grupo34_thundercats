using System.Collections.Generic;
using System.Linq;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {

        private readonly AppContext _appContext = new AppContext();

        // public RepositorioEntidad(AppContext appDbContext)
        // {
        //     _appDbContext = appDbContext;
        // }

        public Entidad Add(Entidad entidad)
        {
            var addedEntity = _appContext.Entidades.Add(entidad);
            _appContext.SaveChanges();
            return addedEntity.Entity;
        }

        public IEnumerable<Entidad> GetAll()
        {
            return _appContext.Entidades;
        }

        public Entidad Get(int pk)
        {
            return _appContext.Entidades.FirstOrDefault(p => p.Id == pk);
        }

        public bool Delete(int pk)
        {
            var entityFound = _appContext.Entidades.FirstOrDefault(p => p.Id == pk);
            if (entityFound == null)
                return false;
            _appContext.Entidades.Remove(entityFound);
            _appContext.SaveChanges();
            return true;
        }

        public Entidad Update(Entidad entidad)
        {
            var entityFound = _appContext.Entidades.FirstOrDefault(p => p.Id == entidad.Id);
            if (entityFound == null)
                return null;

            entityFound.RazonSocial = entidad.RazonSocial ;
            entityFound.Nit = entidad.Nit ;
            entityFound.Ciudad = entidad.Ciudad ;
            entityFound.Direccion = entidad.Direccion ;
            entityFound.Telefono = entidad.Telefono ;
            entityFound.DireccionElectronica = entidad.DireccionElectronica ;
            entityFound.PaginaWeb = entidad.PaginaWeb ;
            entityFound.Sector = entidad.Sector ;
            entityFound.TipoServicio = entidad.TipoServicio ;

            _appContext.SaveChanges();
            return entityFound;
        }
    }
}
