using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion.Pages.Entidades
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioEntidad _repoEntidad;

        public IEnumerable<Entidad> Entidades { get; set; }

        public ListModel(IRepositorioEntidad repoEntidad)
        {
            this._repoEntidad = repoEntidad;
        }
        public void OnGet()
        {
            Entidades = _repoEntidad.GetAll();
        }
    }
}
