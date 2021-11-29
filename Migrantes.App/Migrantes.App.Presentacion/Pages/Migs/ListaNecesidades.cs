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
    public class ListaNecesidadesModel : PageModel
    {
        private readonly IRepositorioMigrante _repoEntity;
         private readonly IRepositorioMigrante _repoMigrante;
          private readonly IRepositorioNecesidades _repoNecesidades;

        public Migrante migrante { get; set; }
        public Migrante migrante1 { get; set; }

        public int numeroDocumento { get; set; }

        public IEnumerable<Necesidades> necesidades { get; set; }

        public ListaNecesidadesModel(IRepositorioNecesidades _repoNecesidades)
        {
    
             this._repoNecesidades=_repoNecesidades;

        }
        public void OnGet()
        {
            necesidades = _repoNecesidades.GetAllNecesidades();
        }
    }
}
