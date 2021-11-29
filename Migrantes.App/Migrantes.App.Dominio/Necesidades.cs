using System;

namespace Migrantes.App.Dominio{

    public enum Tipo{   // Antes en archivo aparte
        Salud,
        Alimentación,
        Empleo,
        AlojamientoTemporal,
        AlojamientoPermanente,
        Educación,
        AyudaLegal
    }
    public enum PrioridadNecesidad{ // Antes en archivo aparte
        Baja,
        Media,
        Alta
    }
    public enum Validacion{ // Antes en archivo aparte
        Atendido,
        No_Atendido,
    
    }
    public class Necesidades {
        public int Id {get;set;}
        public Tipo Tipo {get;set;}
        public string Descripcion {get;set;}
        public PrioridadNecesidad Prioridad {get;set;}
        public Validacion Validacion {get;set;}


    }
}
