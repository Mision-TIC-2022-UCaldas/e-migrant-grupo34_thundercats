using System;
using System.Collections.Generic;
using Migrantes.App.Dominio;
using Migrantes.App.Persistencia;

namespace Migrantes.App.Consola
{
    class Program
    {

        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad();
        private static IRepositorioServicio _repoServicio = new RepositorioServicio();
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante();
        private static IRepositorioNecesidades _repoNecesidades = new RepositorioNecesidades();



        static void Main(string[] args)
        {
            Console.WriteLine("Testing Entidades");
            // TestRepoEntidad();
            // TestRepoServicio();
            //TestAddAmigos();
            // TestAddNecesidades();
        

            // obtenida.Ciudad = "Medellin";
            // Entidad modificada = _repoEntidad.Update(obtenida);
            // Console.WriteLine("Modificada:" + (nueva.Ciudad));

            // bool result = _repoEntidad.Delete(nueva.Id);
            // Console.WriteLine("Borrada: " + result);

        }

    }
}
