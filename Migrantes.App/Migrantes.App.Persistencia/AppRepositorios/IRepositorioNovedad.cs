using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioNovedad {

    IEnumerable<Novedad> GetAll ();

    Novedad  Add (Novedad Novedad );

    Novedad  Update (Novedad  Novedad );

    bool Delete (int idNovedad );

    Novedad  Get (int idNovedad );
    }
}
