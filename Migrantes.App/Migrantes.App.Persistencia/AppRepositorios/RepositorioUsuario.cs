using System.Collections.Generic;
using System.Linq;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {

        private readonly AppDbContext _appContext = new AppDbContext();

        public Usuario Login(string username, string password)
        {
            Usuario usuario = _appContext.Usuarios.FirstOrDefault(p => p.Username == username);

            return usuario;
        }
        public Usuario Add(Usuario entity)
        {
            var addedEntity = _appContext.Usuarios.Add(entity);
            _appContext.SaveChanges();
            return addedEntity.Entity;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _appContext.Usuarios;
        }


        public Usuario Get(int pk)
        {
            return _appContext.Usuarios.FirstOrDefault(p => p.Id == pk);
        }

        public bool Delete(int pk)
        {
            var entityFound = _appContext.Usuarios.FirstOrDefault(p => p.Id == pk);
            if (entityFound == null)
                return false;
            _appContext.Usuarios.Remove(entityFound);
            _appContext.SaveChanges();
            return true;
        }

        public Usuario Update(Usuario entity)
        {
            var entityFound = _appContext.Usuarios.FirstOrDefault(p => p.Id == entity.Id);
            if (entityFound == null)
                return null;

            entityFound.Username = entity.Username ;
            entityFound.Password = entity.Password ;
            entityFound.Rol = entity.Rol ;
            entityFound.EstaActivo = entity.EstaActivo ;

            _appContext.SaveChanges();
            return entityFound;
        }
    }
}
