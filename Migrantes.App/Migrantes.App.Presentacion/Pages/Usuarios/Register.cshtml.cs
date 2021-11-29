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
            return RedirectToPage("./Login");
        }
    }
}
