using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioServicio {

    IEnumerable<Servicio> GetAll ();

    Servicio  Add (Servicio servicio );

    Servicio  Update (Servicio  servicio );

    bool Delete (int idServicio );

    Servicio  Get (int idServicio );
    }
}
