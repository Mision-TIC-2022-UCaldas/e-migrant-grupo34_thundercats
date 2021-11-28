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
        bool IRepositorioMigrante.AddAmigosYFamiliares(int numDocAmigo, Migrante migrante){

            if(migrante == null){
                return false;
            }
            System.Console.WriteLine("el migrante no es nulo");
            // Buscar el objeto amigo
            var amigo = _appContext.Migrantes.FirstOrDefault(p => p.NumeroDocumento == numDocAmigo);

            if (amigo == null){
                return false;
            }
            System.Console.WriteLine("el amigo no es nulo");


            if(migrante.AmigosYFamiliares != null){
                migrante.AmigosYFamiliares.Add(amigo);
            }
            else{
                migrante.AmigosYFamiliares = new List<Migrante>();
                migrante.AmigosYFamiliares.Add(amigo);
            }
                _appContext.SaveChanges();
            return true;
        }



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

            // var MigranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.Id ==  Migrante.Id);
            // if (MigranteEncontrado!=null)

            // {
            //    /* MigranteEncontrado.Nombre=Migrante.Nombre;
            //     MigranteEncontrado.Apellidos=Migrante.Apellidos;
            //     MigranteEncontrado.TipoDocumento=Migrante.TipoDocumento;
            //     MigranteEncontrado.NumeroDocumento=Migrante.NumeroDocumento;
            //     MigranteEncontrado.PaisOrigen=Migrante.PaisOrigen;
            //     MigranteEncontrado.FechaNacimiento=Migrante.FechaNacimiento;*/
            //     MigranteEncontrado.Correo=Migrante.Correo;
            //     MigranteEncontrado.NumeroTelefono=Migrante.NumeroTelefono;
            //     MigranteEncontrado.DireccionActual=Migrante.DireccionActual;
            //     MigranteEncontrado.Ciudad=Migrante.Ciudad;
            //     MigranteEncontrado.SituacionLaboral=Migrante.SituacionLaboral;

            //    return true;
            // }

        }
    }
}
