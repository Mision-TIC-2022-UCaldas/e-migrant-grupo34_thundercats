using System.Collections.Generic;
using System.Linq;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{
    public class RepositorioServicio : IRepositorioServicio
    {

        private readonly AppDbContext _appContext = new AppDbContext();

        // public RepositorioEntidad(AppContext appDbContext)
        // {
        //     _appDbContext = appDbContext;
        // }

        public Servicio Add(Servicio entity)
        {
            var addedEntity = _appContext.Servicios.Add(entity);
            _appContext.SaveChanges();
            return addedEntity.Entity;
        }

        public IEnumerable<Servicio> GetAll()
        {
            return _appContext.Servicios;
        }

        public IEnumerable<Servicio> GetAllByCategoria (Migrantes.App.Dominio.Tipo categoria) {

            return _appContext.Servicios
                .Where(p => p.Categoria  == categoria )
                .ToList();
        }

        public IEnumerable<Servicio> GetAllByEntidad (int pk)                {
            return _appContext.Servicios
                .Where(p => p.EntidadId  == pk )
                .ToList();
        }

        public IEnumerable<Servicio> GetAllByEntidadActivos (int pk)                {
            return _appContext.Servicios
                .Where(p => (p.EntidadId  == pk  && p.EstaActivo))
                .ToList();
        }

        public Servicio Get(int pk)
        {
            return _appContext.Servicios.FirstOrDefault(p => p.Id == pk);
        }

        public bool Delete(int pk)
        {
            var entityFound = _appContext.Servicios.FirstOrDefault(p => p.Id == pk);
            if (entityFound == null)
                return false;
            _appContext.Servicios.Remove(entityFound);
            _appContext.SaveChanges();
            return true;
        }

        public Servicio Update(Servicio entity)
        {
            var entityFound = _appContext.Servicios.FirstOrDefault(p => p.Id == entity.Id);
            if (entityFound == null)
                return null;

            entityFound.NombreServicio = entity.NombreServicio ;
            entityFound.MaxMigrantes = entity.MaxMigrantes ;
            entityFound.FechaInicioOferta = entity.FechaInicioOferta ;
            entityFound.FechaFinOferta = entity.FechaFinOferta ;
            entityFound.EstadoServicio = entity.EstadoServicio ;
            entityFound.Categoria = entity.Categoria ;
            entityFound.EstaActivo = entity.EstaActivo ;


            _appContext.SaveChanges();
            return entityFound;
        }
    }
}
