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
public class EditModel : PageModel
    {
        private readonly IRepositorioNovedad _repoEntity;

        [BindProperty]
        public Novedad Entity { get; set; }

        public EditModel(IRepositorioNovedad repoEntity)
        {
            this._repoEntity = repoEntity;
        }
        public IActionResult OnGet(int? pk)
        {
            if (pk.HasValue)
            {
                Entity = _repoEntity.Get(pk.Value);
            }
            else
            {
                Entity = new Novedad();
            }

            if (Entity == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if (Entity.Id > 0)
            {
                Entity = _repoEntity.Update(Entity);
            }
            else
            {
                _repoEntity.Add(Entity);
            }
            return RedirectToPage("./List");
        }
    }
}
