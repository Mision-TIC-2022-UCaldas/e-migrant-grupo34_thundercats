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
    public class LoginModel : PageModel
    {
        private readonly IRepositorioUsuario _repoEntity;

        [BindProperty]
        public Usuario Entity { get; set; }
        public Usuario UsuarioEncontrado { get; set; }

        public LoginModel(IRepositorioUsuario repoEntity)
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
            } else

            UsuarioEncontrado = _repoEntity.Login(Entity.Username, Entity.Password);

            if (UsuarioEncontrado == null )
            {
                return RedirectToPage("./Login");
            }
            else
            {
                return RedirectToPage("../IndexMigrantes");
            }
        }
    }
}
