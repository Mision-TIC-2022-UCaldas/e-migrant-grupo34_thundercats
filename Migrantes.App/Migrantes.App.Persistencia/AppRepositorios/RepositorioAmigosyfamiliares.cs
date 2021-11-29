using Migrantes.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Migrantes.App.Persistencia{


    public class RepositorioAmigosyfamiliares : IRepositorioAmigosyfamiliares
    {


        private readonly AppDbContext _appContext = new AppDbContext();

        // public AmigosyfamiliaresRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public Amigosyfamiliares AddAmigosyfamiliares(Amigosyfamiliares Amigosyfamiliares)
        {
            var AmigosyfamiliaresAdicionado= _appContext.Amigosyfamiliares1.Add(Amigosyfamiliares);
            _appContext.SaveChanges();
            return AmigosyfamiliaresAdicionado.Entity;
        }

        public void DeleteAmigosyfamiliares(int idAmigosyfamiliares)
        {
            var AmigosyfamiliaresEncontrado=_appContext.Amigosyfamiliares1.FirstOrDefault(p =>p.Id==idAmigosyfamiliares);
            if(AmigosyfamiliaresEncontrado==null)
            return;
            _appContext.Amigosyfamiliares1.Remove(AmigosyfamiliaresEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Amigosyfamiliares> GetAllAmigosyfamiliares()
        {
            return _appContext.Amigosyfamiliares1;
        }

        public Amigosyfamiliares GetAmigosyfamiliares(int idAmigosyfamiliares)
        {
            return _appContext.Amigosyfamiliares1.FirstOrDefault(p =>p.Id==idAmigosyfamiliares);
        }

        public Amigosyfamiliares UpdateAmigosyfamiliares(Amigosyfamiliares Amigosyfamiliares)
        {
            var AmigosyfamiliaresEncontrado=_appContext.Amigosyfamiliares1.FirstOrDefault(p =>p.Id==Amigosyfamiliares.Id);

            if(AmigosyfamiliaresEncontrado!=null)
            {
                AmigosyfamiliaresEncontrado.Relacion=Amigosyfamiliares.Relacion;
              
              


                _appContext.SaveChanges() ;

            }
            return AmigosyfamiliaresEncontrado;
        }

    }
}