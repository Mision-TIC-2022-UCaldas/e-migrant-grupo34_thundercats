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
    }
}

