using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioPersona {

    IEnumerable<Persona> GetAllPersona();

    Persona AddPersona(Persona persona);

    Persona UpdatePersona  (Persona persona);

    void DeletePersona(int idPersona);

    Persona GetPersona(int idPersona);
    }
}