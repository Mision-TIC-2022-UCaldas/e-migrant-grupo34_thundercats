using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrantes.App.Dominio;
using Migrantes.App.Persistencia;

namespace Migrantes.App.Presentacion.Pages.Calificaciones
{
    public class CalificaciondeServiciosModel : PageModel
    {

        private readonly IRepositorioCalificacionServicios _repoCalificacion;
        public CalificacionServicios CalificacionServicios {get;set;}
public  CalificaciondeServiciosModel(IRepositorioCalificacionServicios _repoCalificacion){
        this._repoCalificacion = _repoCalificacion;
    }
    
        public void OnGet()
        {
            CalificacionServicios = new CalificacionServicios();

        }

        public IActionResult OnPost(CalificacionServicios calificacionServicios){
            _repoCalificacion.AddCalificacionServicios(calificacionServicios);
            return RedirectToPage("");

        }
    }
}