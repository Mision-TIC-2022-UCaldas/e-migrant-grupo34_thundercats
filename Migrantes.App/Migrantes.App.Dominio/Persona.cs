using System;


namespace Migrantes.App.Dominio{

    public class Persona{

        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string TipoDocumento{get;set;}
        public string NumeroDocumento {get;set;}

        public string PaisOrigen {get;set;}

        public string FechaNacimiento {get;set;}

    }
}