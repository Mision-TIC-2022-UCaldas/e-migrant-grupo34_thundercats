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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEntidad _repoEntity;
        public Entidad Entity { get; set; }

        public DetailsModel(IRepositorioEntidad repoEntity)
        {
            this._repoEntity = repoEntity;
        }

        public IActionResult OnGet(int pk)
        {
            Entity = _repoEntity.Get(pk);
            if(Entity==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
