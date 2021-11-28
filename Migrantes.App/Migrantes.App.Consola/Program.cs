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

        static void Main(string[] args)
        {
            Console.WriteLine("Testing Entidades");
            TestRepoEntidad();
            // TestRepoServicio();


        }

        static private void TestRepoServicio() {
            var newEntity = new Servicio {
                                NombreServicio = "Cualquiera",
                                MaxMigrantes = 5,
                                FechaInicioOferta = new DateTime(2021,11,26),
                                FechaFinOferta = new DateTime(2021,11,26),
                                EstadoServicio = Migrantes.App.Dominio.EstadoServicio.Activo
                            };
            Servicio nueva = _repoServicio.Add(newEntity);
            _repoServicio.Delete(newEntity.Id);
        }
        static private void TestRepoEntidad() {
            var newEntity = new Entidad
            {
                RazonSocial = "Coomeva",
                Nit = 46484784,
                Ciudad = "Medellin",
                Direccion = "algo",
                Telefono = "445645646",
                DireccionElectronica = "algo",
                PaginaWeb = "algo",
                Sector = Migrantes.App.Dominio.Sector.Otro,
                TipoServicio = Migrantes.App.Dominio.TipoServicio.Educacion
            };

            var newEntityConServicios = new Entidad
            {
                RazonSocial = "Heladeria Americana",
                Nit = 4684874,
                Ciudad = "Barranquilla",
                Direccion = "algo",
                Telefono = "algo",
                DireccionElectronica = "algo",
                PaginaWeb = "algo",
                Sector = Migrantes.App.Dominio.Sector.Otro,
                TipoServicio = Migrantes.App.Dominio.TipoServicio.Educacion,
                Servicios = new List<Servicio> {
                    new Servicio {
                        NombreServicio = "Cualquiera",
                        MaxMigrantes = 5,
                        FechaInicioOferta = new DateTime(2021,11,26),
                        FechaFinOferta = new DateTime(2021,11,26),
                        EstadoServicio = Migrantes.App.Dominio.EstadoServicio.Activo
                    }
                }
            };

            Entidad nueva = _repoEntidad.Add(newEntity);
            Entidad nuevaConServicios = _repoEntidad.Add(newEntityConServicios);

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
