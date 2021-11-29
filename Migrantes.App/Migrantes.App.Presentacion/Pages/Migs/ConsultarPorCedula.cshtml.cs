using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrantes.App.Dominio;
using Migrantes.App.Persistencia;

namespace Migrantes.App.Presentacion.Pages.Migs
{
    public class ConsultarPorCedulaModel : PageModel
    {

        private readonly IRepositorioMigrante _repoMigrante;
        private readonly IRepositorioAmigosyfamiliares _repoAmigosyfamiliares;
        public int numeroDocumento { get; set; }

        public int numeroDocumento1 { get; set; }

        public Amigosyfamiliares amigosyfamiliares {get; set;}

        public Migrante migrante { get; set; }
        public Migrante migrante1 { get; set; }
        // [BindProperty(SupportsGet= true)]
        // public string numeroDocumento{get;set;} = string.Empty;

        public ConsultarPorCedulaModel(IRepositorioMigrante _repoMigrante, IRepositorioAmigosyfamiliares _repoAmigosyfamiliares)
        {
            this._repoMigrante = _repoMigrante;
            this._repoAmigosyfamiliares=_repoAmigosyfamiliares;
        }
        public void OnGet(int numeroDocumento,int numeroDocumento1)
        {
            migrante = _repoMigrante.GetMigrante(numeroDocumento);
            migrante1 = _repoMigrante.GetMigrante(numeroDocumento1);
            
            amigosyfamiliares= new Amigosyfamiliares();

            Console.WriteLine(numeroDocumento);
            Console.WriteLine(numeroDocumento1);
        }

        public void OnPost(Amigosyfamiliares amigosyfamiliares,Migrante migrante, Migrante migrante1){
        _repoMigrante.AddAmigosyfamiliares1(migrante.Id,migrante1.Id,amigosyfamiliares);

        }


    }
}
