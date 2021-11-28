using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;


namespace Migrantes.App.Presentacion.Pages
{
    public class RegistrarAmigoYFamiliarModel : PageModel
    {

        private readonly IRepositorioMigrante _repoMigrante;
        public Migrante Migrante {get;set;}
        public string NumeroDocumento {get;set;}
        public AmigosYFamiliares AmigosyFamiliares {get;set;}

        public RegistrarAmigoYFamiliarModel(IRepositorioMigrante _repoMigrante){
            this._repoMigrante = _repoMigrante;
        }
        public void OnGet(string NumeroDocumento)
        {
            Migrante= _repoMigrante.GetMigrante(NumeroDocumento);

            if(Migrante==null){
                Console.WriteLine("No Encontrado");

            }else{
                Console.WriteLine("Encontrado");
            }

        }

        public void OnPost(string NumeroDocumento, AmigosYFamiliares AmigosyFamiliares){
            _repoMigrante.AddAmigosYFamiliares(NumeroDocumento,AmigosyFamiliares);
        }



    }
}
