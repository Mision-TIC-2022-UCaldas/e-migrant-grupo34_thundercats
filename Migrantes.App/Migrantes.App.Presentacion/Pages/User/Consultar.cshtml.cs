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
    public class ConsultarModel : PageModel
    {

        private readonly IRepositorioMigrante _repoMigrante;
        public string numeroDocumento { get; set; }

        public Migrante migrante { get; set; }
        public Migrante migrante1 { get; set; }
        // [BindProperty(SupportsGet= true)]
        // public string numeroDocumento{get;set;} = string.Empty;

        public ConsultarModel(IRepositorioMigrante _repoMigrante)
        {
            this._repoMigrante = _repoMigrante;
        }
        public void OnGet(string numeroDocumento)
        {
            migrante = _repoMigrante.GetMigrante(numeroDocumento);

            Console.WriteLine(numeroDocumento);
            if (migrante == null)
            {
                Console.WriteLine(numeroDocumento);
            }

            else
            {
                Console.WriteLine(numeroDocumento);

            }
        }
        public IActionResult OnPost(Migrante migrante)
        {
            _repoMigrante.UpdateMigrante(migrante);
            return RedirectToPage("");

        }
    }
}
