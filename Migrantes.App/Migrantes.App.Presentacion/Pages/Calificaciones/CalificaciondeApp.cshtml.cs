using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrantes.App.Dominio;
using Migrantes.App.Persistencia;


namespace Migrantes.App.Presentacion.Pages.Calificaciones
{
    public class CalificaciondeAppModel : PageModel
    {
        private readonly IRepositorioCalificacionApp _repoCalificacion;
        public CalificacionApp CalificacionApp {get;set;}
public  CalificaciondeAppModel(IRepositorioCalificacionApp _repoCalificacion){
        this._repoCalificacion = _repoCalificacion;
    }
    
        public void OnGet()
        {
            CalificacionApp = new CalificacionApp();

        }

        public IActionResult OnPost(CalificacionApp calificacionApp){
            _repoCalificacion.AddCalificacionApp(calificacionApp);
            return RedirectToPage("");

        }
    }
}