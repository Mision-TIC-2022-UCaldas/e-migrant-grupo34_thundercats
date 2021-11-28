using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioMigrante {

    IEnumerable<Migrante> GetAllMigrante ();

    Migrante  AddMigrante (Migrante  migrante );

    Migrante  UpdateMigrante   (Migrante  migrante );

    bool DeleteMigrante (int idMigrante );

    Migrante  GetMigrante (int NumeroDocumento );   // Antes recibia un string

    bool AddAmigosYFamiliares (int idMigrante, Migrante  migrante); // Id del nuevo amigo o familiar

    bool AddNecesidades (int idMigrante, Necesidades necesidades);

    }
}
