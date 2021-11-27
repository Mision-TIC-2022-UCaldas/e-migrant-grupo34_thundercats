using System;
using Migrantes.App.Dominio;
using Migrantes.App.Persistencia;

namespace Migrantes.App.Consola
{
    class Program
    {

        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad();
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Entidades");
            TestRepoEntidad();

        }

        static private void TestRepoEntidad() {
            var newEntity = new Entidad
            {
                RazonSocial = "Helados",
                Nit = 46484784,
                Ciudad = "Medellin",
                Direccion = "algo",
                Telefono = "algo",
                DireccionElectronica = "algo",
                PaginaWeb = "algo",
                Sector = Migrantes.App.Dominio.Sector.Otro,
                TipoServicio = Migrantes.App.Dominio.TipoServicio.Educacion
            };

            Entidad nueva = _repoEntidad.Add(newEntity);
            Console.WriteLine(nueva);

            Entidad obtenida = _repoEntidad.Get(nueva.Id);
            Console.WriteLine("Adicionada:" + (nueva == obtenida));

            var entidades = _repoEntidad.GetAll();
            Console.WriteLine(entidades);

            // obtenida.Ciudad = "Medellin";
            // Entidad modificada = _repoEntidad.Update(obtenida);
            // Console.WriteLine("Modificada:" + (nueva.Ciudad));

            // bool result = _repoEntidad.Delete(nueva.Id);
            // Console.WriteLine("Borrada: " + result);

        }

    }
}
