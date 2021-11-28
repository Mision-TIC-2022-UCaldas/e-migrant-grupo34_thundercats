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
            TestRepoServicio();
            // TestAddAmigos();
            // TestAddNecesidades();
        }

        static private void TestAddNecesidades() {
            var necesidades = new Necesidades {
                Tipo = Migrantes.App.Dominio.Tipo.AlojamientoPermanente,
                Descripcion = "Dolor",
                Prioridad = Migrantes.App.Dominio.PrioridadNecesidad.Alta
            };

           Console.WriteLine(_repoMigrante.AddNecesidades(2, necesidades));
        }
        static private void TestAddAmigos() {
            var migrante = _repoMigrante.GetMigrante(83938938);
            bool result = _repoMigrante.AddAmigosYFamiliares(38392839, migrante);
            Console.WriteLine(result);
        }

        static private void TestRepoServicio() {
            // var newEntity = new Servicio {
            //                     NombreServicio = "Cualquiera",
            //                     MaxMigrantes = 5,
            //                     FechaInicioOferta = new DateTime(2021,11,26),
            //                     FechaFinOferta = new DateTime(2021,11,26),
            //                     EstadoServicio = Migrantes.App.Dominio.EstadoServicio.Activo
            //                 };
            // Servicio nueva = _repoServicio.Add(newEntity);
            // _repoServicio.Delete(newEntity.Id);
            var servicios = _repoServicio.GetAllByEntidad(4);
            foreach (Servicio entity in servicios)
            {
                Console.WriteLine(entity.Id + " - " + entity.NombreServicio);
            }
            Console.WriteLine();

            var serviciosActivos = _repoServicio.GetAllByEntidadActivos(4);
            foreach (Servicio entity in serviciosActivos)
            {
                Console.WriteLine(entity.Id + " - " + entity.NombreServicio);
            }
        }
        static private void TestRepoEntidad() {
            var newEntity = new Entidad
            {
                RazonSocial = "Salud Total",
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
                RazonSocial = "Argos",
                Nit = 4684874,
                Ciudad = "Cartagena",
                Direccion = "algo",
                Telefono = "algo",
                DireccionElectronica = "algo",
                PaginaWeb = "algo",
                Sector = Migrantes.App.Dominio.Sector.Otro,
                TipoServicio = Migrantes.App.Dominio.TipoServicio.Educacion,
                Servicios = new List<Servicio> {
                    new Servicio {
                        NombreServicio = "Otro mas",
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
