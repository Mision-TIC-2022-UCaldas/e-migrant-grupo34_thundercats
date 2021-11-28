using Migrantes.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Migrantes.App.Persistencia{


    public class RepositorioNecesidades : IRepositorioNecesidades
    {


        private readonly AppContext _appContext = new AppContext();

        // public NecesidadesRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public Necesidades AddNecesidades(Necesidades Necesidades)
        {
            var NecesidadesAdicionado= _appContext.Necesidades1.Add(Necesidades);
            _appContext.SaveChanges();
            return NecesidadesAdicionado.Entity;
        }

        public void DeleteNecesidades(int idNecesidades)
        {
            var NecesidadesEncontrado=_appContext.Necesidades1.FirstOrDefault(p =>p.Id==idNecesidades);
            if(NecesidadesEncontrado==null)
            return;
            _appContext.Necesidades1.Remove(NecesidadesEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Necesidades> GetAllNecesidades()
        {
            return _appContext.Necesidades1;
        }

        public Necesidades GetNecesidades(int idNecesidades)
        {
            return _appContext.Necesidades1.FirstOrDefault(p =>p.Id==idNecesidades);
        }

        public Necesidades UpdateNecesidades(Necesidades Necesidades)
        {
            var NecesidadesEncontrado=_appContext.Necesidades1.FirstOrDefault(p =>p.Id==Necesidades.Id);

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