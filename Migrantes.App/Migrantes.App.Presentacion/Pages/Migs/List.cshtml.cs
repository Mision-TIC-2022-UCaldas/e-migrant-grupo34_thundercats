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

        public IEnumerable<Migrante> Entities { get; set; }

        public ListModel(IRepositorioMigrante repoEntity)
        {
            this._repoEntity = repoEntity;
        }
        public void OnGet()
        {
            Entities = _repoEntity.GetAllMigrante();
        }
    }
}
