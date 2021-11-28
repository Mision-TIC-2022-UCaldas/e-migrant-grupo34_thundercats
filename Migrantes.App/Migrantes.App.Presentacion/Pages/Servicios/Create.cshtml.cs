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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioServicio _repoEntity;
        // private readonly IRepositorioEntidad _repoEntidad;

        [BindProperty]
        public Servicio Entity { get; set; }
        public Entidad Entidad { get; set; }

        public CreateModel(IRepositorioServicio repoEntity)
        {
            this._repoEntity = repoEntity;
        }
        public IActionResult OnGet(int? pk)
        {
            if (pk.HasValue)
            {
                // Entidad = _repoEntidad.Get(pk.Value);
                Entity = new Servicio();
                Entity.EntidadId = pk.Value;
                return Page();
            }
            else
            {
                return RedirectToPage("./NotFound");

            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            Console.WriteLine("Creando");

            _repoEntity.Add(Entity);

            return RedirectToPage("../Entidades/List");
        }
    }
}
