using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

    public interface IRepositorioUsuario
    {

        IEnumerable<Usuario> GetAll();

        Usuario Add(Usuario Usuario);

        Usuario Update(Usuario Usuario);

        bool Delete(int idUsuario);

        Usuario Get(int idUsuario);
        Usuario Login(string username, string password);
    }
}
