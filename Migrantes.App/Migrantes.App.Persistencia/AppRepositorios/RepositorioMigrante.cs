using System.Collections.Generic;
using Migrantes.App.Dominio;
using System.Linq;

namespace Migrantes.App.Persistencia{


    public class RepositorioMigrante : IRepositorioMigrante
    {


        private readonly AppContext _appContext = new AppContext();

        // public MigranteRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public Migrante AddMigrante(Migrante Migrante)
        {
            var MigranteAdicionado= _appContext.Migrantes.Add(Migrante);
            _appContext.SaveChanges();
            return MigranteAdicionado.Entity;
        }

        public void DeleteMigrante(int idMigrante)
        {
            var MigranteEncontrado=_appContext.Migrantes.FirstOrDefault(p =>p.Id==idMigrante);
            if(MigranteEncontrado==null)
            return;
            _appContext.Migrantes.Remove(MigranteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Migrante> GetAllMigrante()
        {
            return _appContext.Migrantes;
        }

        public Migrante GetMigrante(int idMigrante)
        {
            return _appContext.Migrantes.FirstOrDefault(p =>p.Id==idMigrante);
        }

        public Migrante UpdateMigrante(Migrante Migrante)
        {
            var MigranteEncontrado=_appContext.Migrantes.FirstOrDefault(p =>p.Id==Migrante.Id);

            if(MigranteEncontrado!=null)
            {
                MigranteEncontrado.Nombre=Migrante.Nombre;
                MigranteEncontrado.Apellidos=Migrante.Apellidos;
                MigranteEncontrado.TipoDocumento=Migrante.TipoDocumento;
                MigranteEncontrado.NumeroDocumento=Migrante.NumeroDocumento;
                MigranteEncontrado.PaisOrigen=Migrante.PaisOrigen;
                MigranteEncontrado.FechaNacimiento=Migrante.FechaNacimiento;
                MigranteEncontrado.Correo=Migrante.Correo;
                MigranteEncontrado.NumeroTelefono=Migrante.NumeroTelefono;
                MigranteEncontrado.DireccionActual=Migrante.DireccionActual;
                MigranteEncontrado.Ciudad=Migrante.Ciudad;
                MigranteEncontrado.SituacionLaboral=Migrante.SituacionLaboral;


                _appContext.SaveChanges() ;

            }
            return MigranteEncontrado;
        }
    }
}