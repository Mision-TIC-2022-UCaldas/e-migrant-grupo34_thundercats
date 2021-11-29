using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion.Pages.Usuarios
{
    public class RegisterModel : PageModel
    {
        private readonly IRepositorioUsuario _repoEntity;

        [BindProperty]
        public Usuario Entity { get; set; }

        public RegisterModel(IRepositorioUsuario repoEntity)
        {
            this._repoEntity = repoEntity;
        }
        public IActionResult OnGet()
        {
                Entity = new Usuario();
                return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("./Error");
            }

            if (Entity.Id > 0)
            {
                Entity = _repoEntity.Update(Entity);
            }
            else
            {
                Usuario nuevo = _repoEntity.Add(Entity);
                if (nuevo == null) {
                    return RedirectToPage("./Error");
                }
            }
            return RedirectToPage("/Index");
        }
    }
}
