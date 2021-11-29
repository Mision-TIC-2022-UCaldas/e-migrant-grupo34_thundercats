using Migrantes.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Migrantes.App.Persistencia;


namespace Migrantes.App.Persistencia{

    public class RepositorioEmergencia: IRepositorioEmergencia{
        private readonly AppDbContext _appContext = new AppDbContext();

        public Emergencias AddEmergencias(Emergencias emergencias)
        {
            var EmergenciaAdicionada= _appContext.Emergencias.Add(emergencias);
            _appContext.SaveChanges();
              return EmergenciaAdicionada.Entity;
        }

        public IEnumerable<Emergencias> GetAllEmergencias()
        {
            return _appContext.Emergencias;
        }
    }
}
          