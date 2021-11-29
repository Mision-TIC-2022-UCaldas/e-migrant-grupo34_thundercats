using System;

namespace  Migrantes.App.Dominio
{

    public enum ValorCalificacion{

        Malo,
        Regular,
        Bueno,
        MuyBueno,
        Excelente
    }
    public class CalificacionApp{

        public int Id{get;set;}

        public ValorCalificacion ValorCalificacion{get;set;}
        public int numeroDocumentoMigrante {get;set;}

    }
    
}