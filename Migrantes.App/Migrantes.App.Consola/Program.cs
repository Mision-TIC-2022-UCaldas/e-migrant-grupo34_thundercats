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
                RazonSocial = "Venta",
                Nit = 12345,
                Ciudad = "Barranquilla",
                Direccion = "algo",
                Telefono = "algo",
                DireccionElectronica = "algo",
                PaginaWeb = "algo",
                Sector = "Migrantes.App.Dominio.Sector.Publico",
                TipoServicio = "Migrantes.App.Dominio.TipoServicio.Salud"
            };

            Entidad nueva = _repoEntidad.Add(newEntity);
            Console.WriteLine(nueva);

            Entidad obtenida = _repoEntidad.Get(nueva.Id);
            Console.WriteLine("Adicionada:" + (nueva == obtenida));

            var entidades = _repoEntidad.GetAll();
            Console.WriteLine(entidades);

            obtenida.Ciudad = "Bogota";
            Entidad modificada = _repoEntidad.Update(obtenida);
            Console.WriteLine("Modificada:" + (nueva.Ciudad));

            bool result = _repoEntidad.Delete(nueva.Id);
            Console.WriteLine("Borrada: " + result);

        }

    }
}
