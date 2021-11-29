using System.Collections.Generic;
using Migrantes.App.Dominio;

namespace Migrantes.App.Persistencia
{

   public interface IRepositorioAmigosyfamiliares {

    IEnumerable<Amigosyfamiliares> GetAllAmigosyfamiliares ();

    Amigosyfamiliares  AddAmigosyfamiliares (Amigosyfamiliares  Amigosyfamiliares );

    Amigosyfamiliares  UpdateAmigosyfamiliares   (Amigosyfamiliares  Amigosyfamiliares );

    void DeleteAmigosyfamiliares (int idAmigosyfamiliares);

    Amigosyfamiliares  GetAmigosyfamiliares (int id);


   }
   }
