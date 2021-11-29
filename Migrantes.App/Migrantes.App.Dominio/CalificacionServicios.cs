using System;

namespace  Migrantes.App.Dominio
{

    public class CalificacionServicios{

        public int Id {get;set;}

        public ValorCalificacion ValorCalificacion {get;set;}

        public TipoServicio TipoServicio {get;set;}

        public int numeroDocumentoMigrante {get;set;}
    }

}