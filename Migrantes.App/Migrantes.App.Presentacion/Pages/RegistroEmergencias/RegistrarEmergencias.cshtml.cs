using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrantes.App.Dominio;
using Migrantes.App.Persistencia;


namespace Migrantes.App.Presentacion.Pages.RegistroEmergencias
{
    public class RegistrarEmergenciasModel : PageModel
    {
        public IEnumerable<Emergencias> emergencias { get; set; }

        
        private readonly IRepositorioEmergencia _repoEmergencias;
        public Emergencias Emergencias {get;set;}

    public  RegistrarEmergenciasModel(IRepositorioEmergencia _repoEmergencias){
        this._repoEmergencias = _repoEmergencias;
    }
    
        public void OnGet()
        {
            Emergencias = new Emergencias();
             emergencias = _repoEmergencias.GetAllEmergencias();

        }

        public IActionResult OnPost(Emergencias Emergencias){
            _repoEmergencias.AddEmergencias(Emergencias);
            return RedirectToPage("");

        }

    }

    }
