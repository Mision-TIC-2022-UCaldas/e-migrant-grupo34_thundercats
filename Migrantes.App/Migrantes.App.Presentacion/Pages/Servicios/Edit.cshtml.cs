using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion.Pages.Servicios
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioServicio _repoEntity;

        [BindProperty]
        public Servicio Entity { get; set; }

        public EditModel(IRepositorioServicio repoEntity)
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
                Entity = new Servicio();
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
                Console.WriteLine("Actualizando");
                Entity = _repoEntity.Update(Entity);
            }
            else
            {
                Console.WriteLine("Creando");

                _repoEntity.Add(Entity);
            }
            return RedirectToPage("../Entidades/List");
        }
    }
}
