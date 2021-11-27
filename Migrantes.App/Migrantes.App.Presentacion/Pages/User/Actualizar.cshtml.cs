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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioMigrante _repoMigrante;

        public Migrante migrante {get; set;}

        public ActualizarModel(IRepositorioMigrante _repoMigrante)
        {
            this._repoMigrante=_repoMigrante;
        }

        public IActionResult OnGet(int id)
        {
            
            migrante=_repoMigrante.GetMigrante(id);

            if(migrante ==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }

        }
        public IActionResult OnPost(Migrante migrante){

            _repoMigrante.UpdateMigrante(migrante);
            return RedirectToPage("/User/VistaMigrante");

         }
    }
}

