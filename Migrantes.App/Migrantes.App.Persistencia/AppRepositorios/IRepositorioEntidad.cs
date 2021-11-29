using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioEntidad {

    IEnumerable<Entidad> GetAll ();

    Entidad  Add (Entidad entidad );

    Entidad  Update (Entidad  entidad );

    bool Delete (int idEntidad );

    Entidad  Get (int idEntidad );
    IEnumerable<Servicio> GetServiciosEntidad(int idEntidad);

    IEnumerable<Entidad> GetAllByCiudad(string ciudad);

     IEnumerable<Entidad> GetAllByNit(int nit);
    }


}
