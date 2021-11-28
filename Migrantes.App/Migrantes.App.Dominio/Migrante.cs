using System;
using System.Collections.Generic;

namespace Migrantes.App.Dominio{

    public class Migrante : Persona{
        
        public string Correo {get;set;}
        public string NumeroTelefono {get;set;}
        public string DireccionActual {get;set;}

        public string Ciudad {get;set;}

        public string SituacionLaboral {get;set;}

        public List<AmigosYFamiliares> AmigosYFamiliares {get;set;}
        
        public  List<Necesidades> Necesidades {get;set;}

    }
}