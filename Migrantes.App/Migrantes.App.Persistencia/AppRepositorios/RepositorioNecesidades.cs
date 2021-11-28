using Migrantes.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Migrantes.App.Persistencia{


    public class RepositorioNecesidades : IRepositorioNecesidades
    {


        private readonly AppDbContext _appContext = new AppDbContext();

        // public NecesidadesRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public Necesidades AddNecesidades(Necesidades Necesidades)
        {
            var NecesidadesAdicionado= _appContext.NecesidadesDb.Add(Necesidades);
            _appContext.SaveChanges();
            return NecesidadesAdicionado.Entity;
        }

        public void DeleteNecesidades(int idNecesidades)
        {
            var NecesidadesEncontrado=_appContext.NecesidadesDb.FirstOrDefault(p =>p.Id==idNecesidades);
            if(NecesidadesEncontrado==null)
            return;
            _appContext.NecesidadesDb.Remove(NecesidadesEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Necesidades> GetAllNecesidades()
        {
            return _appContext.NecesidadesDb;
        }

        public Necesidades GetNecesidades(int idNecesidades)
        {
            return _appContext.NecesidadesDb.FirstOrDefault(p =>p.Id==idNecesidades);
        }

        public Necesidades UpdateNecesidades(Necesidades Necesidades)
        {
            var NecesidadesEncontrado=_appContext.NecesidadesDb.FirstOrDefault(p =>p.Id==Necesidades.Id);

            if(NecesidadesEncontrado!=null)
            {
                NecesidadesEncontrado.Tipo=Necesidades.Tipo;
                NecesidadesEncontrado.Descripcion=Necesidades.Descripcion;
                NecesidadesEncontrado.Prioridad=Necesidades.Prioridad;


                _appContext.SaveChanges() ;

            }
            return NecesidadesEncontrado;
        }

    }
}
