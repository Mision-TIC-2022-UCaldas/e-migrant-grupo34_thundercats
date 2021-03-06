using System.Collections.Generic;
using Migrantes.App.Dominio;
using System.Linq;

namespace Migrantes.App.Persistencia{


    public class RepositorioMigrante : IRepositorioMigrante
    {
        private readonly AppDbContext _appContext = new AppDbContext(); // Antes AppContext

        public Migrante AddMigrante(Migrante migrante)
        {
            var MigranteAdicionado= _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            return MigranteAdicionado.Entity;
        }

        public bool DeleteMigrante(int idMigrante)
        {
            var MigranteEncontrado=_appContext.Migrantes.FirstOrDefault(p =>p.Id==idMigrante);
            if(MigranteEncontrado==null)
            return false;
            _appContext.Migrantes.Remove(MigranteEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        public IEnumerable<Migrante> GetAllMigrante()
        {
            return _appContext.Migrantes;
        }

        public Migrante GetMigrante(int NumeroDocumento)
        {
            return _appContext.Migrantes.FirstOrDefault(p =>p.NumeroDocumento==NumeroDocumento);
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
    
        // bool AddAmigosYFamiliares (int idMigrante, Migrante  migrante);


            bool IRepositorioMigrante.AddNecesidades(int idMigrante, Necesidades necesidades){

            var Migrante= _appContext.Migrantes.FirstOrDefault(p => p.Id == idMigrante);

            if(Migrante != null){
                if(Migrante.Necesidades != null){
                    Migrante.Necesidades.Add(necesidades);
                }
                else{
                    Migrante.Necesidades = new List<Necesidades>();
                    Migrante.Necesidades.Add(necesidades);
                }
                _appContext.SaveChanges();
                return true;
            }
            return false;

      

        }
        bool IRepositorioMigrante.AddAmigosyfamiliares1(int idMigrante,int idMigrante1, Amigosyfamiliares amigosyfamiliares){

            var Migrante= _appContext.Migrantes.FirstOrDefault(p => p.Id == idMigrante);

            amigosyfamiliares.idMigranteAmigo=idMigrante1;
            if(Migrante != null){
                if(Migrante.AmigosYFamiliares != null){
                    Migrante.AmigosYFamiliares.Add(amigosyfamiliares);
                }
                else{
                    Migrante.AmigosYFamiliares = new List<Amigosyfamiliares>();
                    Migrante.AmigosYFamiliares.Add(amigosyfamiliares);
                }
                _appContext.SaveChanges();
                return true;
            }
            return false;

      

        }
    }
}
