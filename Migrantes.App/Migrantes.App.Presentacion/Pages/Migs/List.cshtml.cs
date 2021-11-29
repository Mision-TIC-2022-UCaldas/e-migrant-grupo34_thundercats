using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion.Pages.Migs
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioMigrante _repoEntity;
         private readonly IRepositorioMigrante _repoMigrante;

        public Migrante migrante { get; set; }
        public Migrante migrante1 { get; set; }

        public int numeroDocumento { get; set; }

        public IEnumerable<Migrante> Entities { get; set; }

        public ListModel(IRepositorioMigrante repoEntity,IRepositorioMigrante _repoMigrante)
        {
            this._repoEntity = repoEntity;
             this._repoMigrante = _repoMigrante;

        }
        public void OnGet()
        {
            
            Entities = _repoEntity.GetAllMigrante();

            migrante = _repoMigrante.GetMigrante(numeroDocumento);

            migrante1=_repoMigrante.GetMigrante(numeroDocumento);

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
    public IActionResult OnPost(int idmigrante, int migrante1)
        {
            
            return RedirectToPage("");

        }
    }
}
