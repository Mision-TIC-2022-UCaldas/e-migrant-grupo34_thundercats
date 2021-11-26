using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioMigrante {

    IEnumerable<Migrante> GetAllMigrante ();

    Migrante  AddMigrante (Migrante  migrante );

    Migrante  UpdateMigrante   (Migrante  migrante );

    void DeleteMigrante (int idMigrante );

    Migrante  GetMigrante (int idMigrante );
    }
}