using System;
namespace Migrantes.App.Dominio
{
    public enum EstadoServicio
    {
        Activo,
        Cerrado,
        ConCupo,
        SinCupo,
    }
    public class Servicio
    {
        public int Id {get;set;}

        public int EntidadId {get;set;}

        public string NombreServicio {get;set;}
        public int MaxMigrantes {get;set;}
        public DateTime FechaInicioOferta { get; set; }
        public DateTime FechaFinOferta { get; set; }
        public EstadoServicio EstadoServicio {get; set;}

        public Tipo Categoria {get; set;}
        public bool EstaActivo {get; set;}
    }
}
