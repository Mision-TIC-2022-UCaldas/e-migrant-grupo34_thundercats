using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrantes.App.Dominio;
using Migrantes.App.Persistencia;
 

namespace Migrantes.App.Presentacion.Pages
{
    public class RegistrarNecesidadesModel : PageModel
    {

        
        private readonly IRepositorioMigrante _repoMigrante;
        public Migrante Migrante {get;set;}
        
        public string NumeroDocumento {get;set;}
        public Necesidades Necesidades {get;set;}
       
        public RegistrarNecesidadesModel(IRepositorioMigrante _repoMigrante){
            this._repoMigrante = _repoMigrante;
        }
        public void OnGet(string NumeroDocumento)
        {
            Migrante= _repoMigrante.GetMigrante(NumeroDocumento);
            Console.WriteLine(NumeroDocumento);

            if(Migrante==null){
                Console.WriteLine("No Encontrado");

            }else{
                Console.WriteLine("Encontrado");
            }

        }
    
        public void OnPost(Migrante Migrante, Necesidades Necesidades){

            
          //  Migrante = _repoMigrante.GetMigrante(NumeroDocumento);
            _repoMigrante.AddNecesidades(Migrante.Id,Necesidades);
            Console.WriteLine(Migrante.Id);

            if(Necesidades==null){
                Console.WriteLine("No hay nada en necesidades");
            }
            else{
                Console.WriteLine("Oka");
                
                Console.WriteLine(Necesidades.Descripcion);
            }
        }

    }
}
