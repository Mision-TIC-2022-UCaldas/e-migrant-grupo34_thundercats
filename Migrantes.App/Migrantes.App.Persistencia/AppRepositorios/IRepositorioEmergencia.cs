using Migrantes.App.Dominio;
using System.Collections.Generic;

namespace  Migrantes.App.Persistencia
{
    public interface IRepositorioEmergencia{

        Emergencias  AddEmergencias (Emergencias emergencias);

        IEnumerable<Emergencias> GetAllEmergencias ();
    }
}