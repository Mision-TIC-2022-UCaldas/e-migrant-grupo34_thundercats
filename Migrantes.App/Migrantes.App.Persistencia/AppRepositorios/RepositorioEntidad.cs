using System.Collections.Generic;
using System.Linq;
using Migrantes.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Migrantes.App.Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {

        private readonly AppDbContext _appContext = new AppDbContext();

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

           public IEnumerable<Entidad> GetAllByCiudad(string ciudad) {

            return _appContext.Entidades
                .Where(p => p.Ciudad  == ciudad )
                .ToList();
        }
         public IEnumerable<Entidad> GetAllByNit(int nit) {

            return _appContext.Entidades
                .Where(p => p.Nit  == nit )
                .ToList();
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

        public IEnumerable<Servicio> GetServiciosEntidad(int idEntidad)
        {
            var entidad = _appContext.Entidades.Where(s => s.Id == idEntidad)
                                               .Include(s => s.Servicios)
                                               .FirstOrDefault();

            return entidad.Servicios;
        }
    }
}
