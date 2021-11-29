using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioNecesidades {

    IEnumerable<Necesidades> GetAllNecesidades ();

    Necesidades  AddNecesidades (Necesidades  Necesidades );

    Necesidades  UpdateNecesidades   (Necesidades  Necesidades );

    void DeleteNecesidades (int idNecesidades);

    Necesidades  GetNecesidades (int id);

     //IEnumerable<Necesidades> GetAllByValidacion(int validacion);
   }
   }
