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
    public class ListModel : PageModel
    {
        [BindProperty]
        public Entidad Entidad {get; set;}
        private readonly IRepositorioEntidad _repoEntity;

        public IEnumerable<Servicio> Entities { get; set; }
        public int QtyItems { get; set; }
        public ListModel(IRepositorioEntidad repoEntity)
        {
            this._repoEntity = repoEntity;
        }
        // public void OnGet()
        // {
        //     Entities = _repoEntity.GetAll();
        // }
        public void OnGet(int? entidadId)
        {
            if (entidadId.HasValue)
            {
                Entidad = _repoEntity.Get(entidadId.Value);
            }
            else
            {
                RedirectToPage("./NotFound");
            }
            if (Entidad == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {

                Entities = _repoEntity.GetServiciosEntidad(entidadId.Value);

            }

        }
    }
}
