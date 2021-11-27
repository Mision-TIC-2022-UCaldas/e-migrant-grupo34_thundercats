using System;

namespace Migrantes.App.Dominio
{

    public enum Sector
    {
        Publico,
        Privado,
        SinAnimoDeLucro,
        NoGubernamental,
        Otro
    }
    public enum TipoServicio
    {
        Salud,
        Juridicos,
        Viveres,
        ComidaPreparada,
        Empleo,
        AlojamientoTemporal,
        AlojamientoPermanente,
        Educacion,
        Otros
    }

    public class Entidad
    {
        public int Id {get;set;}
        public string RazonSocial {get;set;}
        public int Nit {get;set;}
        public string Direccion {get;set;}
        public string Ciudad {get;set;}
        public string Telefono {get;set;}
        public string DireccionElectronica {get;set;}
        public string PaginaWeb {get;set;}

        public string Sector {get; set;}
        public string TipoServicio {get; set;}

    }
}
