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
        private readonly IRepositorioServicio _repoEntity;

        public IEnumerable<Servicio> Entities { get; set; }
        public int QtyItems { get; set; }
        public ListModel(IRepositorioServicio repoEntity)
        {
            this._repoEntity = repoEntity;
        }
        public void OnGet()
        {
            Entities = _repoEntity.GetAll();
        }
    }
}
