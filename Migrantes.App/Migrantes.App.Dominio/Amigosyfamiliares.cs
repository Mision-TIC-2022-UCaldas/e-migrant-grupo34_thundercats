using System;
using System.Collections.Generic;

namespace Migrantes.App.Dominio{

    public class Amigosyfamiliares {

        public int Id {get;set;}
        public string Relacion {get;set;}

        public List<Migrante> Migrante {get;set;}

        public int idMigranteAmigo {get; set;}

    }
}