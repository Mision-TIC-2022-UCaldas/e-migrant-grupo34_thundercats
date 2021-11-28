using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion.Pages.Novedades
{
    public class ConsultarNovedadesModel : PageModel
    {
        private readonly IRepositorioNovedad _repoEntity;

        public IEnumerable<Novedad> Entities { get; set; }

        public ConsultarNovedadesModel(IRepositorioNovedad repoEntity)
        {
            this._repoEntity = repoEntity;
        }
        public void OnGet()
        {
            Entities = _repoEntity.GetAll();
        }
    }
}
