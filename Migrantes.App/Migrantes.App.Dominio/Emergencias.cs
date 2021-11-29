using System;

namespace Migrantes.App.Dominio
{

    public enum TipoEmergencia{
        Policial,
        Medica
    }


    public class Emergencias{

        public int Id {get;set;}
        public TipoEmergencia TipoEmergencia {get;set;}

        public string Descripcion {get;set;}
    }

}