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
    public class RegistrarModel : PageModel
    {

        private readonly IrepositorioMigranMigrante _repoMigrante;

        public Migrante migrante {get;set;}

        public RegistrarModel(IrepositorioMigrante _repoMigrante){
            this._repoMigrante = _repoMigrante;
        }
        public void OnGet()
        {
            migrante = new Migrante();
        }

        public IActionResult OnPost(){
            _repoMigrante.AddMigrante(migrante);
            return RedirectToPage("/Migrantes/Index");

        }
    }
}
